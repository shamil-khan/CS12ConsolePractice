using static System.Console;

namespace CS12Basic;

partial class Program
{
    static void NullCoalescingSample()
    {
        string? name = null;
        WriteLine(name ?? "name is null"); 
       
        name ??= "unknown";
        WriteLine(name);
    }

    static void SystemInfo()
    {
        WriteLine($"Machine name: {Env.MachineName}");   
        WriteLine($"Username: {Env.UserName}");
    }

    static void ShowEmoji()
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        WriteLine(char.ConvertFromUtf32(0x1F600));
    }

    static void ShowEmojiLeftPattern()
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        var happyface = char.ConvertFromUtf32(0x1F600);

        for (var i = 1; i <= 20; i++)
        {
            for(var j=1; j<=i; j++)
            {
                Write($"{happyface} ");
            }
            WriteLine();
        }
    }
}