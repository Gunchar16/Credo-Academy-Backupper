using System;
using System.Globalization;
using System.IO;


namespace Backup
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time;
            try
            {
                time = DateTime.ParseExact(args[0], "d-M-yyyy", new CultureInfo("ka-GE"));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            Backupper.Backup(args[1], args[2], time);
        }
    }
}