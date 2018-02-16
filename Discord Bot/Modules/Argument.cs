using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class Argument : ModuleBase<SocketCommandContext>
    {
        [Command("Argument")]
        public async Task ArgumentAsync(string name)
        {
            await ReplyAsync($"Your argument is {name}");
        }
    }
}
