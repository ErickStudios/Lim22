
////!
////! makelima
////!
////! the compiler solution for non-scratch lima applications
////!

using System.Reflection.Metadata.Ecma335;

namespace makelima {
partial class makelima_compiler
{
    ////!
    ////!
    ////!
    ////! keywords
    ////!
    ////!
    ////!

    public string if_keyword = "if";
    public string package_keyword = "package";

    ////!
    ////!
    ////!
    ////! worckspcae
    ////!
    ////!
    ////!

    public string worckspace = "C:\\";

    ////!
    ////!
    ////!
    ////! functions
    ////!
    ////!
    ////!

    ///!
    ///!
    ///! GetFile
    ///!
    ///! Get the file in the current worckspace can search in /dependences/ or from the root of
    ///! the worckspace
    ///!
    ///!
    public string
        GetFile
        (
            string file
        )
    {
        //
        // setup
        //

        string result;

        string worckspaceplus_file;
        string worckspaceplus_file_plus_dependences;

        //
        // settings
        //

        result = "# file not founded";

        worckspaceplus_file = Path.Join(worckspace, file);

        worckspaceplus_file_plus_dependences = Path.Join(worckspace, "dependences", file);

        //
        // parsing
        //

        if (
            File.Exists(worckspaceplus_file_plus_dependences)
            )
        {
            result = File.ReadAllText(worckspaceplus_file_plus_dependences);
        }
        else
        if (
            File.Exists(worckspaceplus_file)
        )
        {
            result = File.ReadAllText(worckspaceplus_file);
        }

        if (
            file[0] == '/'
            )
        {
            string rfile = file.Substring(1);

            worckspaceplus_file = Path.Join(worckspace, rfile);

            if (
                    File.Exists(worckspaceplus_file)
                )
            {
                result = File.ReadAllText(worckspaceplus_file);
            }
        }

        return result;
    }

    ///!
    ///!
    ///! ConvertLima
    ///!
    ///! solve al imports and typedefs in the lima file
    ///!
    ///!
    public string
        ConvertLima
        (
            string text
        )
    {
        //
        // setuping
        //

        string result;

        string dependence_to_solve;

        string typedef_solve_name;
        string typedef_solve_value;

        //
        // setting
        //

        result = text;

        result = result.Replace("\r", "");

        dependence_to_solve = "stdlib.lima";

        //
        // ct
        //

        string[] lines = result.Split("\n");

        for (int i = 0; i < lines.Length; i++)
        {
            if (
                lines[i].Trim().StartsWith("#")
                )
            {
                result = result.Replace(lines[i] + "\n", "");
            }
            else if (
                  lines[i].Trim() == ""
                )
            {
                result = result.Replace("\n" + lines[i] + "\n", "\n");
            }
            else if (
                lines[i].Trim() == "import"
                )
            {
                if (
                    lines[i + 2].Trim() == ";"
                    )
                    dependence_to_solve = lines[i + 1].Trim();

                result = result.Replace("import\n" + lines[i + 1] + "\n;", GetFile(dependence_to_solve + ".lima"));
            }
        }

        return result;
    }

    ///!
    ///!
    ///! makelima_sintax
    ///!
    ///! makelima_sintax
    ///!
    ///!
    public string
       makelima_sintax
       (
           string text
       )
    {
        string result;

        result = text.Trim();

        if (
            result.StartsWith("\"") && result.EndsWith("\"")
            )
        {
            result = result.Substring(1, result.Length - 2);
        }
        else if (
            result.StartsWith("exist ")
            )
        {
            if (
                GetFile(result.Substring(6, result.Length - 6)) != "# file not founded"
                )
            {
                return "true";
            }
            return "false";
        }

        return result;
    }

    ///!
    ///!
    ///! makelima_package
    ///!
    ///! package a file
    ///!
    ///!
    public void
        makelima_package
        (
        string src_file,
        string dest_file,
        string action
        )
    {
        if (
            action == "convert_to"
            )
        {
            File.WriteAllText(Path.Join(worckspace, dest_file), ConvertLima(GetFile(src_file)));
        }
        else if (
            action == "coppy_to"
            )
        {
            File.WriteAllText(Path.Join(worckspace, dest_file), GetFile(src_file));
        }
    }

    public void
        makelima_command
        (
        string command
        )
    {
        if (
            command.StartsWith("package ")
            )
        {
            string c = command.Substring(8, command.Length - 8);

            string[] args = c.Split(" -> ");

            makelima_package(makelima_sintax(args[0]), makelima_sintax(args[2]), makelima_sintax(args[1]));
        }
        else if (
                command.StartsWith("each ")
            )
        {
            string c = command.Substring(5, command.Length - 5);

            string[] args = c.Split(" -> ");

            if (
                Path.Exists(Path.Join(worckspace, makelima_sintax(args[0])).Replace("/", "\\"))
                )
            {
                for (
                    global::System.Int32 i = 0;
                    i < Directory.GetFiles(Path.Join(worckspace, makelima_sintax(args[0])).Replace("/", "\\")).Length;
                    i++
                    )
                {
                    string cm = args[1];

                    string[] erre = Directory.GetFiles(Path.Join(worckspace, makelima_sintax(args[0])).Replace("/", "\\"));

                    for (int j = 2; j < args.Length; j++)
                    {
                        cm += " -> " + args[j];
                    }

                    string elñe = erre[i].Replace(worckspace, "").Replace("\\", "/");

                    cm = cm.Replace("%file", elñe);

                    string filename = elñe.Substring(1, elñe.LastIndexOf(".") - 1);

                    string[] erasd = filename.Split('/');

                    filename = erasd[erasd.Length - 1];

                    cm = cm.Replace("%fname", filename);

                    makelima_command(cm);
                }
            }
        }
    }

    ///!
    ///!
    ///! makelima_interprete
    ///!
    ///! compile advance with makelima.mkl
    ///!
    ///!
    public void
        makelima_interprete
        (
            string text
        )
    {
        string result;

        result = text;

        result = result.Replace("\r", "");

        string[] lines = result.Split('\n');


        for (int i = 0; i < lines.Length; i++)
        {
            if (
                lines[i].Trim().StartsWith(if_keyword)
                )
            {
                string condition = lines[i].Trim().Substring((if_keyword + "").Length, lines[i].Trim().Length - (if_keyword + "").Length);

                string[] temp_cond = condition.Split(" then ");

                condition = temp_cond[0];

                if (
                    makelima_sintax(condition) != "false"
                    )
                {

                }
            }
            else
            {
                makelima_command(lines[i]);
            }
        }


    }


    public void
    WorkOn
    (
        string line
        )
    {
        worckspace = line.Substring(0, line.LastIndexOf('\\'));

        makelima_interprete(GetFile("/makelima.mkl"));
    }
}
}