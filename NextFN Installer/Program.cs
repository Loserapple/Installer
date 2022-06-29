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
            var Num = Console.ReadLine();

            switch(Num)
            {
                case "1":
                    Install();
                break;
                case "one":
                    Install();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                case "two":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Incorrect input, press any key to close");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }

        public static void Install()
        {
            Console.Write("Where would you like to install to: ");
            var Dir = Console.ReadLine();
            var DirFinish = Dir + @"\downloaded.zip";
            using (var client = new WebClient())
            {
                Console.Clear();
                Console.WriteLine("Installation has Started");
                client.DownloadFile("LINKHERE", Dir + @"\downloaded.zip");
                System.IO.Compression.ZipFile.ExtractToDirectory(DirFinish, Dir);
                File.Delete(DirFinish);
                Console.WriteLine("Installation has completed!");
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
        } 
    }
}
