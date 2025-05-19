using System;
using System.Collections.Generic;
using System.Linq;
using Removeduplicatesnamespace;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ListProcessor listProcessor = new ListProcessor();
listProcessor.ProcessList();

Console.WriteLine("Program ended.");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
// End of the program
// This program demonstrates how to remove duplicates from a list of integers