﻿namespace Bakery.IO
{
    using Bakery.IO.Contracts;
    using System;
    using System.IO;

    public class Writer : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            File.AppendAllText("../../../text.txt", message + Environment.NewLine);
            Console.WriteLine(message);
        }
    }
}
