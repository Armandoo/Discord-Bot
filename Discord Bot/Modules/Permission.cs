using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Modules
{
    public class Permission : ModuleBase<SocketCommandContext>
    {
        //Examples bot
        //[Command("Permission"),RequireBotPermission(GuildPermission.ManageChannels)] // only bots who have permission to manage channels
        //[Command("Permission"), RequireBotPermission(GuildPermission.ManageRoles)] //  only bots who have permission to manage channels
        //[Command("Permission"), RequireBotPermission(ChannelPermission.AddReactions)] //  only bots who have permission to add reaction in channel

        //Example users
        //[Command("Permission"), RequireUserPermission(GuildPermission.BanMembers)] // Only user who have permission ban in the guild
        [Command("Permission"), RequireUserPermission(ChannelPermission.MentionEveryone)] // Only user who have permission to mention everyone
        public async Task PermissionAsync(string name)
        {
            await ReplyAsync($"Your argument is {name}");
        }
    }
}
