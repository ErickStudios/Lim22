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

namespace TurbowarpPortedLima
{
    class Lima // literary the "lima" objet , is very portable , no?
    {
        // apenas puse esto aqui por que olvide que en lima son globales estos diccionarios
        public Dictionary<string, string>
         lima_variables // the variable "lima variables" in turbowarp
         =
        new Dictionary<string, string>();

        public graphichsMode gop = new graphichsMode();

        public bool trueflag = false;

        public Dictionary<string, string>
         globvars
         =
        new Dictionary<string, string>();

        public int Line_to_execute = 0; // literary the name says all
                                 // there variable too exist in the lima objet

        public Dictionary<int, int> popback = new Dictionary<int, int>();

        public Dictionary<int, string> segments = new Dictionary<int, string>();

        public string[] blocks_to_execute;       // other lima turbowarp reference
        
        public struct Lima_Ex_Affected
        {
            public int type;
            public string id;
            public string new_value;
        }

        public struct LimaExeption
        {
            public bool CloseProgram;
            public int line;

            public bool FromVariable;

            // from variable if true params
            public string varname;

            public int from_mem_direction;
            public int to_mem_direction;

            public Dictionary<int, Lima_Ex_Affected> affected_zones;

            public void ShowExecption()
            {
                int scroll = 0;

                while (true)
                {
                    string line_sep = ""; // for the "---------------------"

                    for (int i = 0; i < Console.BufferWidth; i++)
                    {
                        line_sep = line_sep + "-";
                    }

                    Console.Clear();

                    Console.WriteLine("line: " + line.ToString());
                    Console.Write(line_sep);

                    for (int i = scroll; i < (scroll + Console.BufferHeight) - 5; i++)
                    {
                        if (affected_zones.ContainsKey(i))
                        {
                            Console.WriteLine("type:" + affected_zones[i].type.ToString() + " @" + affected_zones[i].id + "\t->\t" + affected_zones[i].new_value);
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                    }
                    Console.WriteLine("if you dont know what is this , is just a Lima Exepction Development tool");

                    ConsoleKeyInfo Key = Console.ReadKey(true);

                    if (
                        Key.Key == ConsoleKey.UpArrow
                        )
                    {
                        scroll--;
                    }

                    if (
                         Key.Key == ConsoleKey.DownArrow
                     )
                    {
                        scroll++;
                    }

                }
            }
        }

        public string 
            AskForMessageIntoSegment
            (
                string msg
            )
        {
            for (int i = 0; i < segments.Count; i++)
            {
                if (
                    segments[i].Contains("[intersegmental]\nmessage " + msg)
                    )
                {
                    string[] sr = segments[i].Split("[intersegmental]\nmessage " + msg);

                    string[] ara_ara = sr[1].Split("\n[endmsg]");

                    return ara_ara[0];
                }
            }

            return "";
        }

        public string
        LimaSyntax
        (
        string e,
        bool debug
        )
            {
            if (
                    e.Contains("(..)")
                    )
                {
                    string[] split = e.Split("(..)");

                string syntax = "";
                    
                    foreach (var item in split)
                    {
                        syntax += LimaSyntax(item,debug);
                    }
                    return syntax;
            }
            else if (
                e.StartsWith("(") && e.EndsWith(")")
                )
            {
                string ifcond = e.Substring(1, e.Length - 2);

                if (
                    ifcond.Contains("==")
                    )
                {
                    string[] split = ifcond.Split("==");

                    if (
                        LimaSyntax(split[0],debug) == LimaSyntax(split[1],debug)
                        )
                    {
                        return "true";
                    } else
                    {
                        return "false";
                    }
                }

                if (
                    ifcond.Contains("!=")
                    )
                {
                    string[] split = ifcond.Split("!=");

                    if (
                        LimaSyntax(split[0], debug) != LimaSyntax(split[1], debug)
                        )
                    {
                        return "true";
                    } else
                    {
                        return "false";
                    }
                }

                return "false";
            }
            else if (
                    e.StartsWith("\"") && e.EndsWith("\"")
                    )
                {
                    return e.Substring(1, e.Length - 2);
                }
                else if (
                    lima_variables.ContainsKey(e)
                    )
                {
                    return lima_variables[e];
                }
                else if (
                    e.StartsWith('&')
                        )
                {
                    return e.Substring(1);
                }
                else if (
                    e == "Scratch.GetYear"
                    )
                {
                    return (DateTime.Now.Year).ToString();
                }
                else if (
                    e == "Scratch.GetMonth"
                    )
                {
                    return (DateTime.Now.Month).ToString();
                }
                else if (
                    e == "Scratch.GetDay"
                )
                {
                    return (DateTime.Now.Day).ToString();
                }
                else if (
                    e == "Scratch.GetHour"
                    )
                {
                    return (DateTime.Now.Hour).ToString();
                }
                else if (
                    e == "Scratch.GetMinute"
                    )
                {
                    return (DateTime.Now.Minute).ToString();
                }
                else if (
                    e.StartsWith("@ScratchVar(")
                )
                {
                    string er = e.Substring(12, e.Length - 13);

                    if (
                    globvars.ContainsKey(er)
                    )
                    return globvars[er];

                return "";
                }
                else if (
                      e == "Scratch.GetSecond"
                    )
                {
                    return (DateTime.Now.Second).ToString();
                }
                else if (e == "nullptr")
                {
                    return "";
                }
                else if (e == "NULL")
                {
                    return "";
                }
                else if (
                    e == "@debug"
                    )
                {
                    return debug.ToString();
                }
                else if (
                    e == "ReadKeyWait"
                    )
                {
                    return Console.ReadKey(true).KeyChar.ToString();
                }
                else if (
                    e == "ReadLine"
                    )
                {
                string em = Console.ReadLine();
                    return em == null ? "" : em;
                }
            else if
    (
        e.Contains("(->)")
    )
            {
                string[] split = e.Split("(->)");

                if (
                    split[1].StartsWith("[") &&
                    split[1].EndsWith("]")
                    )
                {
                    string item = split[1].Replace("[", "");
                    item = item.Replace("]", "");

                    string[] array = lima_variables[split[0]].Replace("\r","").Split("\n");

                    if (array.Length < Convert.ToInt32(lima_variables[item]))
                        return array[Convert.ToInt32(lima_variables[item])];
                    return "undefined";
                }
            }
            return e;
            }

        public async void
            Execute
            (
            string e,
            bool debug
            )
        {
            if (e.StartsWith("echo "))
            {
                Console.WriteLine(LimaSyntax(e.Substring(5, e.Length - 5), debug));
            }
            if (e.StartsWith("cecho "))
            {
                string texto = LimaSyntax(e.Substring(6, e.Length - 6), debug);
                int x = (Console.WindowWidth - texto.Length) / 2; // Calcula la posición horizontal
                int y = Console.WindowHeight / 2; // Calcula la posición vertical

                int oldx = Console.CursorLeft;
                int oldy = Console.CursorTop;

                Console.SetCursorPosition(x, y); // Mueve el cursor al centro
                Console.WriteLine(texto);

                Console.CursorLeft = oldx;
                Console.CursorTop = oldy;
            }
            if (e.StartsWith("button_echo "))
            {
                string texto = LimaSyntax(e.Substring(12, e.Length - 12), debug);
                int x = (Console.WindowWidth - texto.Length) / 2; // Calcula la posición horizontal
                int y = Console.WindowHeight - 1; // Calcula la posición vertical

                int oldx = Console.CursorLeft;
                int oldy = Console.CursorTop;

                Console.SetCursorPosition(x, y); // Mueve el cursor al centro
                Console.WriteLine(texto);

                Console.CursorLeft = oldx;
                Console.CursorTop = oldy;
            }
            else if (e == "%^\"!p\"")
            {
                if (
                   globvars["@eax"] == "/file_gName"
                    )
                {
                    IEnumerable<string> names = Directory.EnumerateFiles(globvars["@dircurrent"]);

                    string[] nrt = names.ToArray();

                    globvars["_returned"] = Path.GetFileName(nrt[Convert.ToInt32(globvars["@bx"])]);
                }
                else if (
                    globvars["@eax"] == "/glob -gtv -array_startswith"
                    )
                {
                    string array = "";
                    foreach (var item in globvars.ToArray())
                    {
                        if (item.Key.StartsWith(globvars["@bx"])) array += item + "\n";
                    }
                    globvars["_returned"] = array;
                }
                else if (
                    globvars["@eax"] == "/dir countf"
                    )
                {
                    IEnumerable<string> names =Directory.EnumerateFiles(globvars["@dircurrent"]);

                    string[] nrt = names.ToArray();

                    globvars["_returned"] = nrt.Length.ToString();
                }
                else if (
                   globvars["@eax"] == "/file_gContent"
                    )
                {
                    IEnumerable<string> names = Directory.EnumerateFiles(globvars["@dircurrent"]);

                    string[] nrt = names.ToArray();

                    globvars["_returned"] = File.ReadAllText(nrt[Convert.ToInt32(globvars["@bx"])]);
                }
                else if (
                    globvars["@eax"] == "/get-url"
                    )
                {
                    string url = globvars["@bx"];

                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            // Enviar una solicitud GET y obtener la respuesta
                            HttpResponseMessage response = await client.GetAsync(url);

                            // Asegurarse de que la solicitud fue exitosa
                            response.EnsureSuccessStatusCode();

                            // Leer el contenido de la respuesta como una cadena
                            string content = await response.Content.ReadAsStringAsync();

                            globvars["_returned"] = content;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }

            }
            else if (e.StartsWith("writel "))
            {
                Console.Write(LimaSyntax(e.Substring(7, e.Length - 7), debug));
            }
            else if (e.StartsWith("color "))
            {
                string er = e.Substring(6, e.Length - 6);

                string[] colors = er.Split(" ");

                string foreground = LimaSyntax(colors[0],debug);

                string background = LimaSyntax(colors[1],debug);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.BackgroundColor += int.Parse(background);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.ForegroundColor += int.Parse(foreground);

            }
            else if (
                e.StartsWith("sendmw ")
                )
            {
                int line_to = Line_to_execute;
                Dictionary<int, int> recover_popback = popback;

                //Console.WriteLine(e);

                Line_to_execute = 0;
                ExecuteLimaScript(AskForMessageIntoSegment(e.Substring(7, e.Length - 7)), debug);

                Line_to_execute = line_to + 1;

                popback = recover_popback;
            }
            else if (
                e == "cls"
                )
            {
                Console.Clear();
            }
            else if (
                e.StartsWith("sleep ")
                )
            {
                Thread.Sleep(int.Parse(LimaSyntax(e.Substring(6, e.Length - 6), debug)) * 1000);
            }

            return;
        }

        public string
            Operate_With
            (
                string operator1,
                string a,
                string operator2

            )
        {
            if (a == "=") return operator2; // the equal simbol
            if (a == "+=") // the sum simbol
            {
                if (
                    int.TryParse(operator1, out int value1) == false // if the operator1 is a text
                    )
                {
                    if (
                        int.TryParse(operator2, out int value2) // if the operator2 is a number
                    )
                    {
                        return operator1.Substring(int.Parse(operator2), operator1.Length - int.Parse(operator2)); // desplaze it
                    }
                    else
                    {
                        return operator1 + operator2; // if not a number join the texts
                    }
                }
                else
                {
                    return (int.Parse(operator1) + int.Parse(operator2)).ToString(); // if a number the two sum it
                }
            }
            if (a == "-=") // the sub simbol
            {
                if (
                    int.TryParse(operator1, out int value1) == false // if the operator1 is a text
                    )
                {
                    if (
                        int.TryParse(operator2, out int value2) // if the operator2 is a number
                    )
                    {
                        return operator1.Substring(0, operator1.Length - int.Parse(operator2)); // desplaze it
                    }
                    else
                    {
                        return operator2; // if not a number return the operator 2
                    }
                }
                else
                {
                    return (int.Parse(operator1) - int.Parse(operator2)).ToString(); // if a number the two sum it
                }
            }
            if (a == "*=")
            {
                return (int.Parse(operator1) * int.Parse(operator2)).ToString();
            }
            return operator2;
        }

        public async void
        ExecuteLimaScript
        (
            string lscript,
            bool debug
        )
        {
            bool in_struct;

            string script = lscript.Replace("\r","");

            string[] lines = script.Split(new[] { '\n' });

            while (
                Line_to_execute < lines.Length
                )
            {
               //Console.WriteLine(Line_to_execute.ToString() + ": " + lines[Line_to_execute]);

                if (
                    lines[Line_to_execute].Trim() == "@structure"
                    )
                {
                    in_struct = true;

                    string structuredefinition = "";

                    while (
                        lines[Line_to_execute].Trim() != "}"
                        )
                    {
                        if (
                            lines[Line_to_execute].Trim() == "prototype"
                            )
                        {
                            if (lines[Line_to_execute + 2].Trim() == "var")
                                structuredefinition = structuredefinition + lines[Line_to_execute + 1].Trim() + "|" + lines[Line_to_execute + 3].Trim() + "\n";
                            else
                            {
                                structuredefinition = structuredefinition + (
                                    lima_variables[lines[Line_to_execute + 1].Trim()]
                                    ).
                                    Replace("|", "|" + lines[Line_to_execute + 3].Trim(
                                    ) + "->"
                                    )
                                    ;
                            }
                        }
                        Line_to_execute++;
                    }

                    Line_to_execute++;

                    lima_variables[lines[Line_to_execute].Trim()] = structuredefinition;

                    in_struct = false;
                    //Console.WriteLine(structuredefinition);
                }
                else if (
                    (lines[Line_to_execute]).Trim() == "mov"
                )
                {
                    //Console.WriteLine(Line_to_execute + 1.ToString() + ": " + lines[Line_to_execute + 1]);

                    globvars[(lines[Line_to_execute + 1]).Trim()] = LimaSyntax((lines[Line_to_execute + 2]).Trim(), debug);
                }
                else if (
                        (lines[Line_to_execute]).Trim() == "ustruct"
                    )
                {
                }
                else if (
                    (lines[Line_to_execute]).Trim() == "org"
                    )
                {
                   segments[int.Parse((lines[Line_to_execute + 1]).Trim())] = script;
                }
                else if (
                    (lines[Line_to_execute]).Trim() == "if"
                    )
                {
                    //Console.WriteLine("in if");
                    string if_condition;

                    if_condition =
                        (lines[Line_to_execute + 1]).Trim() + // (
                        (lines[Line_to_execute + 2]).Trim() + // ...
                        (lines[Line_to_execute + 3]).Trim() + // operator
                        (lines[Line_to_execute + 4]).Trim() + // ...
                        (lines[Line_to_execute + 5]).Trim() // )
                        ;

                    Line_to_execute += 6;

                    //Console.WriteLine(if_condition);

                    //Console.WriteLine(LimaSyntax(if_condition, debug));

                    if (
                        LimaSyntax(if_condition,debug) != "false"
                        )
                    {
                        //Console.WriteLine("xd");
                        string popcode = lscript;

                        Dictionary<int, int> ppopback = popback;

                        string code = "";

                        int ele = 0;
                        while (
                                lines[Line_to_execute].Trim() != "}" && ele != 0
                            )
                        {
                            code += lines[Line_to_execute] + "\n";

                            Line_to_execute++;

                            if (
                                lines[Line_to_execute].Trim() == "{"
                                )
                            {
                                ele++;
                            }

                            if (
                                lines[Line_to_execute].Trim() == "}"
                                )
                            {
                                ele--;
                            }
                        }

                        if (
                                                    LimaSyntax(if_condition, debug) != "false"
                                                    )
                        {
                            int popline = Line_to_execute;

                            popback.Clear();

                            Line_to_execute = 0;

                            ExecuteLimaScript(code, debug);

                            Line_to_execute = popline;

                            popback = ppopback;
                        }
                    }
                    else
                    {
                        //Console.WriteLine("yo");
                        int ele = 0;

                        while (
                            true
                            )
                        {
                            //Console.WriteLine(Line_to_execute);
                            Line_to_execute++;

                            if (
                                lines[Line_to_execute].Trim() == "{"
                                )
                            {
                                ele++;
                            }

                            if (
                                lines[Line_to_execute].Trim() == "}"
                                )
                            {
                                if
                                    (
                                    ele == 0
                                    )
                                {
                                    break;
                                }
                                else
                                ele--;
                            }
                        }

                    }
                }
                else if (
                    (lines[Line_to_execute]).Trim() == "var"
                    )
                {
                    string name = (lines[Line_to_execute + 1]).Trim();
                    string op = (lines[Line_to_execute + 2]).Trim();
                    string value = (lines[Line_to_execute + 3]).Trim();

                    if (
                        (lines[Line_to_execute - 1]).Trim() == "[globalize]"
                        )
                    {
                        globvars[name] = Operate_With(
                            globvars.ContainsKey(name) ? globvars[name] : "",
                            op,
                            LimaSyntax(value, debug)
                            );
                    }
                    else
                    {
                        lima_variables[name] = Operate_With(
                            lima_variables.ContainsKey(name) ? lima_variables[name] : "",
                            op,
                            LimaSyntax(value, debug)
                            );
                    }
                }
                else if (
                    (lines[Line_to_execute]).Trim() == "jump" ||
                    (lines[Line_to_execute]).Trim() == "jt" ||
                    (lines[Line_to_execute]).Trim() == "jf"

                    )
                {
                    int section_search;

                    for (section_search = 0; section_search < lines.Length; section_search++)
                    {
                        if (
                            lines[section_search].Trim() == "section"
                            )
                        {
                            if (
                                lines[section_search + 1].Trim() == lines[Line_to_execute + 1].Trim()
                                )
                            {
                                if (
                                    (lines[Line_to_execute]).Trim() == "jf"
                                    )
                                {
                                    if (lima_variables[".cnd"] == "false")
                                    {
                                        popback.Add(popback.Count + 1, Line_to_execute + 1);
                                        Line_to_execute = section_search;
                                    }
                                }
                                else if
                                    (
                                     (lines[Line_to_execute]).Trim() == "jt"
                                    )
                                {
                                    if (lima_variables[".cnd"] != "false")
                                    {
                                        popback.Add(popback.Count + 1, Line_to_execute + 1);
                                        Line_to_execute = section_search;
                                    }
                                }
                                else
                                {
                                    popback.Add(popback.Count + 1, Line_to_execute + 1);
                                    Line_to_execute = section_search;
                                }
                            }
                        }
                    }
                }
                else if (
                    lines[Line_to_execute] == "popback"
                    )
                {
                    if (popback.Count != 0)
                    {
                        Line_to_execute = popback[popback.Count];
                        popback.Remove(popback.Count);
                    }
                    else
                    {
                        Line_to_execute = 0;
                    }
                }
                else if (
                    lines[Line_to_execute] == "__endprog__"
                    )
                {
                    return;
                }
                else
                {
                    Execute(lines[Line_to_execute].Trim(), debug);
                }

                Line_to_execute++;

            }
            return;
        }
    }

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
                    string path = line.Substring(0, line.LastIndexOf("\\"));

                    lima.globvars["@dircurrent"] = path;

                    lima.popback.Clear();
                    lima.Line_to_execute = 0;

                    lima.ExecuteLimaScript(File.ReadAllText(line).Replace("\r", ""), false);
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Lim22>");

                    string line = Console.ReadLine();

                    lima.popback.Clear();
                    lima.Line_to_execute = 0;
                    if (
                        line != ""
                        )
                    {
                        string path = line.Substring(0, line.LastIndexOf("\\"));

                        lima.globvars["@dircurrent"] = path;

                        lima.ExecuteLimaScript(File.ReadAllText(line).Replace("\r", ""), false);
                    }
                }
            }
        }
    }
}