using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    [Group("GroupPing")]
    public class Grouping : ModuleBase<SocketCommandContext>
    {
        [Command]
        public async Task DefaultPing()
        {
            await ReplyAsync("A simple ping from group");
        }

        [Command("Second")]
        public async Task SecondPing()
        {
            await ReplyAsync("Second ping from group");
        }

        [Command("Third")]
        public async Task ThirdPing(string name)
        {
            await ReplyAsync($"Third ping from group with ouput: {name}");
        }
    }
}
