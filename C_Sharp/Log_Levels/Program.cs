using System;
using Log_Levels.Models;

namespace Log_Levels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Message()
            Console.WriteLine(LogLine.Message("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.Message("[WARNING]:  Disk almost full\r\n"));

            // LogLevel()
            Console.WriteLine(LogLine.LogLevel("[ERROR]: Invalid operation"));

            // Reformat()
            Console.WriteLine(LogLine.Reformat("[INFO]: Operation completed"));
            Console.WriteLine(LogLine.Reformat("[ERROR]: Segmentation fault"));

        }
    }
}