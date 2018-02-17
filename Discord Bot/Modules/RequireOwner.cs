using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class RequireOwner : ModuleBase<SocketCommandContext>
    {
        [Command("RequireOwner"), RequireOwner]
        public async Task RequireOwnerAsync()
        {
            //could also use it like this
            //if (Context.User.Id == 1234567890) 


            await ReplyAsync("Only the bot owner can use this function");
        }
    }
}
