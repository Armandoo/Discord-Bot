using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("Ping")]
        public async Task PingAsync()
        {
            await ReplyAsync("pong");
        }
    }
}
