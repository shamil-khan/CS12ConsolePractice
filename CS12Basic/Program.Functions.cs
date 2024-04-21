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
        var happyFace = char.ConvertFromUtf32(0x1F600);

        for (var i = 1; i <= 50; i++)
        {
            for(var j=1; j<=i; j++)
            {
                Write($"{happyFace} ");
            }
            WriteLine();
        }
    }

    static void ShowSwitchPatternMatching()
    {
        var animals = new Animal?[]
        {
            new Cat { Name="Karen", Born=new(2004, 8, 23), Legs=4, IsDomestic = true },
            new Cat { Name="Mufasa", Born=new(1994, 6, 15)},
            null,
            new Spider { Name="Sid Vicious", Born = DateTime.Today, IsPoisonous = true},
            new Spider {Name="Captain Furry", Born = DateTime.Today}
        };

        WriteLine("-------------------------- Switch Pattern Match 1 --------------------------");
        foreach (Animal? animal in animals)
        {
            var message = string.Empty;
            switch (animal)
            {
                case Cat cat when cat.Legs == 4:
                    message = $"Cat {cat.Name} is domestic";
                    break;
                case Cat cat when cat.IsDomestic == false: 
                    message = $"Cat {cat.Name} is NOT domestic";
                    break;
                case Cat cat:
                    message = $"Cat {cat.Name} is unknown";
                    break;
                case null:
                    message = "The animal is null";
                    break;
                default:
                    message = $"{animal.Name} is of type {animal.GetType().Name}";
                    break;
                case Spider spider when spider.IsPoisonous:
                    message = $"Spider {spider.Name} is poisonous. Run!";
                    break;
                case Spider spider:
                    message = $"Spider {spider.Name} is born {spider.Born.ToShortDateString()}";
                    break;
            }
            
            WriteLine(message ?? "Unknown");
        }
        
        WriteLine("-------------------------- Switch Pattern Match 2 --------------------------");
        foreach (Animal? animal in animals)
        {
            var message = string.Empty;
            switch (animal)
            {
                case Cat {Legs: 4} cat:
                    message = $"Cat {cat.Name} is domestic";
                    break;
                case Cat {IsDomestic: false} cat: 
                    message = $"Cat {cat.Name} is NOT domestic";
                    break;
                case Cat cat:
                    message = $"Cat {cat.Name} is unknown";
                    break;
                case null:
                    message = "The animal is null";
                    break;
                default:
                    message = $"{animal.Name} is of type {animal.GetType().Name}";
                    break;
                case Spider {IsPoisonous: true} spider:
                    message = $"Spider {spider.Name} is poisonous. Run!";
                    break;
                case Spider spider:
                    message = $"Spider {spider.Name} is born {spider.Born.ToShortDateString()}";
                    break;
            }
            
            WriteLine(message ?? "Unknown");
        }
        
        WriteLine("-------------------------- Switch Pattern Match 3 --------------------------");
        foreach (var animal in animals)
        {
            string message = animal switch
            {
                Cat { Legs: 4 } cat => $"Cat {cat.Name} is domestic",
                Cat { IsDomestic: false } cat => $"Cat {cat.Name} is NOT domestic",
                Cat cat => $"Cat {cat.Name} is unknown",
                null => "The animal is null",
                Spider { IsPoisonous: true } spider => $"Spider {spider.Name} is poisonous. Run!",
                Spider spider => $"Spider {spider.Name} is born {spider.Born.ToShortDateString()}",
                _ => $"{animal.Name} is of type {animal.GetType().Name}"
            };

            WriteLine(message ?? "Unknown");
        }
        
    }
}