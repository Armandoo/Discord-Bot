using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Discord_Bot
{
    class Program { 


        private readonly string _token = "NDEzMzM1MjI5NTUwNTU5MjM1.DWXUCw.UNwIIdRpImlTDPB9swwhpxkF_J0";

        private DiscordSocketClient _client;

        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;
            _client.MessageReceived += MessageReceived;

            await _client.LoginAsync(TokenType.Bot, _token);
            await _client.StartAsync();

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private async Task MessageReceived(SocketMessage message)
        {
            if (message.Content == "!ping")
            {
                await message.Channel.SendMessageAsync("Pong!");
            }else if (message.Content == "!ikben")
            {
                await message.Channel.SendMessageAsync("TURK TURK TURK!");

            }
        }
    }
}