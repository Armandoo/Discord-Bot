using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Discord_Bot
{
    class Program { 

        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;

        public static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();

            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();

            _client.Log += Log;

            _client.UserJoined += AnnouceUserJoined;

            await RegisterCommandsAsync();


            var token = System.IO.File.ReadAllText(@"..\token.txt");

            await _client.LoginAsync(TokenType.Bot, token);

            await _client.StartAsync();

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        //When new user joins a guild/server
        private async Task AnnouceUserJoined(SocketGuildUser user)
        {
            var guild = user.Guild;
            var channel = guild.DefaultChannel;
            await channel.SendMessageAsync($"Welcome {user.Mention}");

        }

        public async Task RegisterCommandsAsync()
        {
            _client.MessageReceived += HandleCommandAsync;

            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }

        //Handles the Commands/Messages
        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;

            if (message is null || message.Author.IsBot) return;

            int argPos = 0;

            if(message.HasStringPrefix("!",ref argPos) || message.HasMentionPrefix(_client.CurrentUser, ref argPos))
            {
                var context = new SocketCommandContext(_client, message);

                var result = await _commands.ExecuteAsync(context, argPos, _services);

                if (!result.IsSuccess)
                    Console.WriteLine(result.ErrorReason);
            }
            else if (message.Content == "!wiebenik")
            {
                await message.Channel.SendMessageAsync(message.Author.Username);
                await message.Channel.SendMessageAsync("message testing");
            }
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());

            //Function is not async
            return Task.CompletedTask;
        }
        
    }
}