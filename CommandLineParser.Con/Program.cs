// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

namespace CommandLineParser.Con
{
    using System;
    using CommandLine;

    public class Options
    {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }

        public static Options Default()
        {
            return new Options
            {
                Verbose = true
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CommandLineParser DEMO!");

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                {
                    if (o.Verbose)
                    {
                        Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
                        Console.WriteLine("Quick Start Example! App is in Verbose mode!");
                    }
                    else
                    {
                        Console.WriteLine($"Current Arguments: -v {o.Verbose}");
                        Console.WriteLine("Quick Start Example!");
                    }
                });
        }
    }
}