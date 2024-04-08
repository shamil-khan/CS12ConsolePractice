namespace CS12Basic;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Hello, World!");
        NullCoalescingSample();
    }

    static void NullCoalescingSample()
   {
       string? name = null;
       WriteLine(name ?? "name is null"); 
       
       name ??= "unknown";
       WriteLine(name);
    }
}