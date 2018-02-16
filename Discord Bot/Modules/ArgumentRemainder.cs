using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class ArgumentRemainder : ModuleBase<SocketCommandContext>
    {
        [Command("ArgumentRemainder")]
        public async Task ArgumentRemaindertAsync(string name, [Remainder] string remainder)
        {
            await ReplyAsync($"First input: {name}, Remainder: {remainder}");
        }
    }
}
