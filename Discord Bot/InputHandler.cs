using Discord.WebSocket;
using System;
using System.Threading.Tasks;

public class InputHandler
{
    SocketMessage input;
    private static string _prefix = "";

    public InputHandler(SocketMessage input)
    {
        this.input = input;
    }

    public async Task handler()
    {
        bool t = input.Content.StartsWith(_prefix);
        if (t)
        {
            if (input.Content == "ping")
            {
                await input.Channel.SendMessageAsync("Pong!");
            }
            else if (input.Content == "!ikben")
            {
                await input.Channel.SendMessageAsync("TURK TURK TURK!");

            }
            else if (input.Content == "!help")
            {
                await input.Channel.SendMessageAsync(input.Author.Mention);
            }
        }
        
    }
}
