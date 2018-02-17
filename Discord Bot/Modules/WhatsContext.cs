using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class WhatsContext : ModuleBase<SocketCommandContext>
    {
        [Command("WhatsContext")]
        public async Task WhatsContextAsync()
        {
            /*In program.cs on line 74 
             * We create new SocketCommandContext and give it out client and message
             * that context executeAsync on our command service
             */


            //Context.Client
            //Context.User
            //Context.Guild
            //Context.Message
            //Context.Channel

            await ReplyAsync(
                $"Client: {Context.Client.CurrentUser.Mention} \n " +
                $"User: {Context.User.Mention} \n " +
                $"Message: {Context.Message.Content} \n " +
                $"Guild: {Context.Guild.Name} \n" +
                $"Channel: {Context.Channel.Name}"
            );
        }
    }
}
