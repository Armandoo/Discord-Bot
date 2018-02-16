using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class ArgumentDefault : ModuleBase<SocketCommandContext>
    {
        [Command("ArgumentDefault")]
        public async Task ArgumentDefaultAsync(string name = "defaultstring")
        {
            await ReplyAsync($"This argument has a default string defaultstring, in case u forgot to fill in an argument \n Output: {name}");
        }
    }
}
