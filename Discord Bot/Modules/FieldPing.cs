using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class FieldPing : ModuleBase<SocketCommandContext>
    {
        [Command("FieldPing")]
        public async Task FieldPingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Field one","Normal field")
                .AddInlineField("Field two","inline field")
                .AddInlineField("Field three", "also an inline field");

            builder.Title = "Hammer is ya boi";
            builder.ImageUrl = "https://placeimg.com/640/480/tech";


            await ReplyAsync("", false, builder.Build());
        }
    }
}