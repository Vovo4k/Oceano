﻿using System;

namespace Oceano.Commands
{
    public class neofetch
    {
        static readonly string cpu = Cosmos.Core.CPU.GetCPUBrandString();
        static readonly int total = (int)Cosmos.Core.CPU.GetAmountOfRAM();
        static readonly int used = (int)Cosmos.Core.GCImplementation.GetUsedRAM() / 10000;
        public static void Init()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@"  _.====.._               "); Console.Write("   Oceano");
            Console.WriteLine();
            Console.Write(@" ,:._       ~-_           "); Console.ForegroundColor = ConsoleColor.White; Console.Write("   ----------"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write(@"    `\        ~-_         "); Console.Write("   OS: "); Console.ForegroundColor = ConsoleColor.White; Console.Write("Oceano beta1 x86/x64"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write(@"      |          `.       "); Console.Write("   Host: "); Console.ForegroundColor = ConsoleColor.White; Console.Write("oceano"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write(@"     /            ~-_     "); Console.Write("   Kernel: "); Console.ForegroundColor = ConsoleColor.White; Console.Write("Cosmos Dev Kit v106027"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write(@"..-''               ~~--.."); Console.Write("   Shell: "); Console.ForegroundColor = ConsoleColor.White; Console.Write("Wave Shell 1.0"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write(@"                          "); Console.Write("   Resolution: "); Console.ForegroundColor = ConsoleColor.White; Console.Write("undefined"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write(@"                          "); Console.Write("   CPU: "); Console.ForegroundColor = ConsoleColor.White; Console.Write(cpu); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.Write(@"                          "); Console.Write("   Memory: "); Console.ForegroundColor = ConsoleColor.White; Console.Write(used + "/"); Console.Write(total + "MB"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}