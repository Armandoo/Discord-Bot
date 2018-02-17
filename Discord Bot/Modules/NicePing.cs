using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class NicePing : ModuleBase<SocketCommandContext>
    {
        [Command("NicePing")]
        public async Task NicePingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("The ping")
                    .WithDescription("This ping is made with EmbedBuilder")
                    .WithColor(Color.Red);

            await ReplyAsync("", false, builder.Build());
        }
    }
}
