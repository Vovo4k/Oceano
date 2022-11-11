﻿using System;
using System.IO;

namespace Oceano.Commands
{
    public class MakeDirectory : Command
    {
        public MakeDirectory(String name) : base(name) { }

        public override String execute(String[] args)
        {

            string response;
            try
            {
                Directory.CreateDirectory(Kernel.path + args[0]);
                Console.ForegroundColor = ConsoleColor.Green;
                response = "Directory " + args[0] + "created.";
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                response = "Error: " + ex.Message;
            }
            return response;
        }
    }
}