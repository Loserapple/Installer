using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Reflection;

namespace NextFN_Installer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "NextFN Installer | created by array0x#4908";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("== [ ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Discord: https://dsc.gg/nextfn ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("] ==\n\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to NextFN");
            Console.WriteLine("How would you like to install?");
            Console.WriteLine("1. Full");
            Console.WriteLine("2. Exit");
            Console.Write("Selection: ");
            var Number = Console.ReadLine();

            if(Number == "1" || Number == "one")
            {
                Console.Write("Where would you like to install to: ");
                var Dir = Console.ReadLine();
                var DirFinish = Dir + @"\downloaded.zip";
                using(var client = new WebClient())
                {
                    Console.WriteLine("[LOG] Downloading Zip");
                    client.DownloadFile("https://nextfncdn.nextfndev.repl.co/ChromeSetup.zip", Dir + @"\downloaded.zip");
                    Console.WriteLine("[LOG] Downloaded Zip");
                    Console.WriteLine("[LOG] Extracting Zip");
                    System.IO.Compression.ZipFile.ExtractToDirectory(DirFinish, Dir);
                    Console.WriteLine("[LOG] Extracted Zip");
                    Console.WriteLine("[LOG] Deleting old Zip");
                    File.Delete(DirFinish);
                    Console.WriteLine("[LOG] Installation Completed!");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("The installation has completed successfully, Please make sure to join our Discord at ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("https://dsc.gg/nextfn\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to close");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            } else if (Number == "2" || Number == "two") {
                Environment.Exit(0);
            } else {

            }

            Console.ReadKey();
        }
    }
}
