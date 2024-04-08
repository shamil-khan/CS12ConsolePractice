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
}