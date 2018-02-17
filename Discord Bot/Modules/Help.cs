using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task help()
        {
            SocketUser Author = Context.Message.Author;            
            await ReplyAsync("Dont worry " + Author.Mention + ", help is underway! :ambulance: ");
            sendPM(Author);
        }

        public async void sendPM(SocketUser Author)
        {
            await Author.SendMessageAsync("Help is here :ambulance: ", false, null, null);
        }
        


    }
}
