using System;

public class InputHandler
{
    string input = input;
    
    public InputHandler(string input)
    {
        this.input = input;
    }

    public void input()
    {
        if (input == "!ping")
        {
            await message.Channel.SendMessageAsync("Pong!");
        }
        else if (input == "!ikben")
        {
            await message.Channel.SendMessageAsync("TURK TURK TURK!");

        }
        else if (input == "!wiebenik")
        {
            await message.Channel.SendMessageAsync(message.Author.Username);
            await message.Channel.SendMessageAsync("message testing");
        }
    }
}
