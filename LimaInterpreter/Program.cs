/*
 el objetivo de esto no es crear un clon completamente si no un lima-compatible interprete
*/

using System;
using System.Net;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Net.Sockets;
using System.Net.Http;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using LimaInterpreter;

using makelima;

namespace TurbowarpPortedLima
{

    class Program
    {
        public static void
            Main(
                string[] args
            )
        {
            Lima lima = new Lima();

            lima.globvars["@eax"] = "waiting";
            lima.globvars["@bx"] = "waiting";

            if (
                args.Length != 0
                )
            {
                foreach (string line in args)
                {
                    if (Path.GetExtension(line) == "lima") {
                        string path = line.Substring(0, line.LastIndexOf("\\"));

                        lima.globvars["@dircurrent"] = path;

                        lima.popback.Clear();
                        lima.Line_to_execute = 0;

                        lima.ExecuteLimaScript(File.ReadAllText(line).Replace("\r", ""), false);
                    }
                    else if
                        (
                        Path.GetExtension(line) == "mkl"
                        )
                    {
                        makelima_compiler com = new makelima_compiler();

                        com.WorkOn(line);
                    }
                    else
                    {
                        Console.WriteLine("the file is not a makelima or a lima script");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Lim22 (lima interpreter + makelima program pack)");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("type mkl for swich to makelima");
            Console.WriteLine("type lima for swich to lima");
            Console.ForegroundColor = ConsoleColor.Gray;

            bool makelima_mode = false;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("*");
                if (
                    makelima_mode == false
                    )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("lima");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("@Lim22");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(" interpreter\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("make");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("lima");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("@Lim22");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(" compiler\n");
                    Thread.Sleep(50);
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("> ");
                Thread.Sleep(50);

                string line = Console.ReadLine();

                lima.popback.Clear();
                lima.Line_to_execute = 0;

                if (
                    line == "mkl"
                    )
                {
                    makelima_mode = true;
                }
                else if
                    (
                    line == "lima"
                    )
                {
                    makelima_mode = false;
                }
                else if (
                    line != ""
                    )
                {
                    if (
                        File.Exists(line)
                        )
                    {
                        if (
                            makelima_mode == false
                            )
                        {
                            string path = line.Substring(0, line.LastIndexOf("\\"));

                            lima.globvars["@dircurrent"] = path;

                            lima.ExecuteLimaScript(File.ReadAllText(line).Replace("\r", ""), false);
                        }
                        else
                        {
                            makelima_compiler compiler = new makelima_compiler();

                            compiler.WorkOn(line);
                        }
                    }
                    else
                    {
                        if (
                            makelima_mode == true
                            )
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                        }
                    }
                }
            }
        }
    }
}