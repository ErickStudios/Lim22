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
using Lima_LimaPlusPlus_interpreter;

using makelima;
using System.Windows.Controls;

namespace TurbowarpPortedLima
{

    class Program
    {
        public static string
            MenuShow
            (
                string title,
                ConsoleColor fgns,
                ConsoleColor bgns,
                ConsoleColor fgs,
                ConsoleColor bgs,
                string[] options
            )
        {
            int option = 0;
            while (true)
            {
                Console.ForegroundColor = fgns;
                Console.BackgroundColor = bgns;

                int x = (Console.WindowWidth - 44) / 2; /// Calcula la posición horizontal
                int y = ((Console.WindowHeight - (options.Length / 2)) / 2); /// Calcula la posición vertical

                Console.SetCursorPosition(
                    x,
                    y - 3
                    );
                Console.WriteLine("************************************************");

                for (int i = 0; i < options.Length + 2; i++)
                {
                    Console.SetCursorPosition(
                    x,
                    y - (2 - i)
                    );
                    Console.WriteLine("*                                              *");
                }

                Console.SetCursorPosition(
                x + 2,
                y - 2
                );
                Console.Write(title);

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(
                    x + 2,
                    y - (1 - i)
                    );

                    if (
                        i == option
                        )
                    {
                        Console.ForegroundColor = fgs;
                        Console.BackgroundColor = bgs;
                    }
                    else
                    {
                        Console.ForegroundColor = fgns;
                        Console.BackgroundColor = bgns;
                    }

                    Console.WriteLine(options[i]);

                    Console.ForegroundColor = fgns;
                    Console.BackgroundColor = bgns;
                }

                Console.SetCursorPosition(
                    x,
                    y - (1 - options.Length)
                    );
                Console.WriteLine("************************************************");


                ConsoleKeyInfo Key = Console.ReadKey(true);

                if (
                    Key.Key == ConsoleKey.UpArrow
                    )
                {
                    option--;
                }
                else if (
                    Key.Key == ConsoleKey.DownArrow
                    )
                {
                    option++;
                }
                else if (
                    Key.Key == ConsoleKey.Enter
                    )
                {
                    break;
                }
            }

            return options[option];
        }

        public static void
            WriteAndRun(
            )
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            string code = "";
            Console.WriteLine("Ready");
            Console.WriteLine(" ");
            while (true)
            {
                string line = Console.ReadLine();

                if (
                    line == "run"
                    )
                {
                    Lima lima = new Lima();

                    try
                    {
                        lima.ExecuteLimaScript(code, true);
                    }
                    catch (Exception ex)
                    {
                        string[] exception_options = { "debug", "continue", "exit" };
                        int option = 0;
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.DarkYellow;

                            int x = (Console.WindowWidth - 29) / 2; /// Calcula la posición horizontal
                            int y = (Console.WindowHeight / 2) - exception_options.Length + 3; /// Calcula la posición vertical

                            Console.SetCursorPosition(
                                x,
                                y - 3
                                );
                            Console.WriteLine("*********************************");

                            for (int i = 0; i < exception_options.Length + 2; i++)
                            {
                                Console.SetCursorPosition(
                                x,
                                y - (2 - i)
                                );
                                Console.WriteLine("*                               *");
                            }

                            Console.SetCursorPosition(
                            x + 2,
                            y - 2
                            );
                            Console.Write("An exception has been ocurred");

                            for (int i = 0; i < exception_options.Length; i++)
                            {
                                Console.SetCursorPosition(
                                x + 2,
                                y - (1 - i)
                                );

                                if (
                                    i == option
                                    )
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.BackgroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                }

                                Console.WriteLine(exception_options[i]);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                            }

                            Console.SetCursorPosition(
                                x,
                                y - (3 - 5)
                                );
                            Console.WriteLine("*********************************");


                            ConsoleKeyInfo Key = Console.ReadKey(true);

                            if (
                                Key.Key == ConsoleKey.UpArrow
                                )
                            {
                                option--;
                            }
                            else if (
                                Key.Key == ConsoleKey.DownArrow
                                )
                            {
                                option++;
                            }
                            else if (
                                Key.Key == ConsoleKey.Enter
                                )
                            {
                                break;
                            }
                        }

                        switch (option)
                        {
                            case 0:
                                Console.WriteLine("this error ocurred on the line: " + (lima.Line_to_execute + 1).ToString());
                                break;
                            default:
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("exiting");
                                break;
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Ready");
                    Console.WriteLine(" ");

                    code = "";
                }
                else if (
                    line == "exit"
                    )
                {
                    break;
                }
                else
                {
                    code += line + "\n";
                }
            }
        }

        public static void
            Explorer
            (
                string folder
            )
        {
            ///
            /// obtener la lista de archivos
            ///

            string[] dirs = Directory.GetDirectories(folder);
            string[] files = Directory.GetFiles(folder);

            string[] optionsrt = dirs.ToArray();
            optionsrt = optionsrt.AsEnumerable().Concat(files).ToArray();

            for (int i = 0; i < optionsrt.Length; i++)
            {
                optionsrt[i] = Path.GetFileName(optionsrt[i]);
            }

            string[] header_options = { "=back","=mkdir" , "=war" , ".." ," " };

            string[] options = header_options.AsEnumerable().Concat(optionsrt).ToArray();

            MenuShow("e", ConsoleColor.Gray, ConsoleColor.Blue, ConsoleColor.DarkCyan, ConsoleColor.Magenta, options);
        }

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
                        string path = line.Substring(0, line.LastIndexOf(Path.DirectorySeparatorChar.ToString()));

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
                Console.BackgroundColor = ConsoleColor.Black;

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
                else if (
                    line == "war"
                    )
                {
                    WriteAndRun();
                }
                else if (
                    line == "explorer"
                    )
                {
                    Explorer(AppDomain.CurrentDomain.BaseDirectory);
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

#if !DEBUG
                            try

                            {
#endif
                                lima.ExecuteLimaScript(File.ReadAllText(line).Replace("\r", ""), false);
#if !DEBUG

                            }
#endif
#if !DEBUG

                            catch (Exception ex)
                            {
                                string[] exception_options = { "debug", "continue", "exit" };
                                int option = 0;
                                while (true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;

                                    int x = (Console.WindowWidth - 29) / 2; /// Calcula la posición horizontal
                                    int y = (Console.WindowHeight / 2) - exception_options.Length + 3; /// Calcula la posición vertical

                                    Console.SetCursorPosition(
                                        x,
                                        y - 3
                                        );
                                    Console.WriteLine("*********************************");

                                    for (int i = 0; i < exception_options.Length + 2; i++)
                                    {
                                        Console.SetCursorPosition(
                                        x,
                                        y - (2 - i)
                                        );
                                        Console.WriteLine("*                               *");
                                    }

                                    Console.SetCursorPosition(
                                    x + 2,
                                    y - 2
                                    );
                                    Console.Write("An exception has been ocurred");

                                    for (int i = 0; i < exception_options.Length; i++)
                                    {
                                        Console.SetCursorPosition(
                                        x + 2,
                                        y - (1 - i)
                                        );

                                        if (
                                            i == option
                                            )
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.BackgroundColor = ConsoleColor.White;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                                        }

                                        Console.WriteLine(exception_options[i] );

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    }

                                    Console.SetCursorPosition(
                                        x,
                                        y - (3 - 5)
                                        );
                                    Console.WriteLine("*********************************");


                                    ConsoleKeyInfo Key = Console.ReadKey(true);

                                    if (
                                        Key.Key == ConsoleKey.UpArrow
                                        )
                                    {
                                        option--;
                                    }
                                    else if (
                                        Key.Key == ConsoleKey.DownArrow
                                        )
                                    {
                                        option++;
                                    }
                                    else if (
                                        Key.Key == ConsoleKey.Enter
                                        )
                                    {
                                        break;
                                    }
                                }

                                switch (option)
                                {
                                    case 0:
                                        Console.WriteLine("this error ocurred on the line: " + (lima.Line_to_execute + 1).ToString());
                                        break;
                                    default:
                                        Console.BackgroundColor = ConsoleColor.Black;

                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("exiting");
                                        break;
                                }
                    }
#endif
                }
                    else
                        {
                            makelima_compiler compiler = new makelima_compiler();

                            compiler.WorkOn(line);
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("script '" + line + "' not founded");
                    }
                }
            }
        }
    }
}