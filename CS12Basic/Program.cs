﻿namespace CS12Basic;

partial class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        WriteLine(char.ConvertFromUtf32(0x1F600));
        SystemInfo();
        NullCoalescingSample();
    }
}