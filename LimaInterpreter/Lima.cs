///
/// Lima 2025
///
/// cualquier robo del interprete o que hayan robado la idea sin mi permiso avisar al
/// ErickCraftStudios@outlook.com, y si no pues, bueno , no te pasa nada por no avisarme pero
/// de preferencia avisenme de esas cosas que me costo mucho hacer la logica
/// 
/// Coppyright (aun no de momento no esta registrado por ahora pero ya para avisarles con tiempo
/// ) (C) ErickCraftStudios
/// Coppyright (aun no de momento no esta registrado por ahora pero ya para avisarles con tiempo
/// ) (C) ECS Markarian
/// 
/// 

///
/// descripcion 
///

///
/// 
/// lima escrito por ErickCraftStudios y markarian
/// 
/// Lima es un lenguaje de programacion diseñado para adolesentes , niños , programadores de
/// todo el mundo y mucho mas
/// 
/// Lima mantiene una sintaxis muy facil de recordar similar a C++, javascript y ensamblador
/// aunque no se preocupen por lo de ensamblador, lima es facil hasta que quieres hacer
/// algo tecnico ahi si , tendras que usar mov @eax, @bx @ax y comados del interprete (%^"!p")
/// 
/// por otro lado Lima++ es un componente de lima muy versatil pero dificil de manejar, sirve
/// para cosas muy complejas como clases, metodos y cosas de la programacion orientada a
/// objetos o POO para los amigos
///



///
/// reglas de comunidad
///

///     
///     
///     1.Evita usar Lima para propaganda politica
///
///     2. Evita realizar cosas inapropiadas como contenido pornografico con Lima
///
///     3. Recuerda que puedes leer la documentacion!, aparte, en la paguina [Linuxchad] (< https://foro.linuxchad.org)> se encuentran algunos recursos
///
///     4.Se respetuoso a la hora de reportar algo
///
///     5. Evita "manchar" la reputacion de lima
///
///
/// los desarrolladores de lima te mandan un abrazo y que te la pases genial con el lenguaje de progamacion ^-^
/// 
///

///
/// recuerda usar el interprete cuidadosamente, luego puede fallar con algunas cosas
/// y no es mi culpa , trabajo solo , como quieres que no falle derrepente
///

///
/// antes de usar
/// 

/// antes de usar lima debe tener los conocimientos previos
/// *haber leido la documentacion sobre cosas tecnicas si vas a hacer eso
/// 
/// *saber usar vscode
/// 
/// *saber compilar programas, si usa linux debera portear el interprete a menos de que
///  microsoft haga un compilador para linux
///  
///


///
/// preguntas frecuentes
/// 

///
/// preguntas frecuentes, realmente no me pidieron mi opinion pero por cualquier cosa
/// 
/// ¿se puede hacer un sistema operativo en lima? si y no, si por que el lenguaje tiene funciones
/// de bajo nivel y no por que es un interprete
/// 
/// ¿hiciste lima con alguien? bueno la verdad lo hice todo solo , aunque hay alguien que
/// esta haciendo su propio interprete para linux es skale
/// 
/// "lima es una porqueria hecha por alguien que no deberia hacerlo", bueno la verdad siendo
/// honestos, lima no es una poruqeria (tampoco lo mejor del mundo) pero es lo suficiente
/// para varios programadores (pd: solo yo a la hora de escribir esto)
/// 
/// ¿hasta donde puede llegar lima? la verdad NO LO SE , solo se que ya he podido crear un
/// firmware dentro de lima pero solo funciona en el interprete
/// 
/// ¿es lima opensource? si, se puede modificar y redistribuir y no se que mas con el codigo
/// pero por favor no te adueñes del codigo, si lo vas a hacer dame creditos
/// 
/// 
///

///
/// ahora si vamos con el archivo
///

///
/// incluir los archivos
///

using System;                                                   /// incluir el sistema
using System.Linq;                                              /// linq

using System.Text;                                              /// incluir Text
using System.Threading.Tasks;                                   /// incluir las tareas

using System.Drawing;                                           /// para el cursor
using System.Collections.Generic;                               /// incluir los diccionarios

///
/// definir algunos alias
///

using LimObj = string;      /// recuerden : aqui en lima no discriminamos a nadie, aqui una
                            /// variable es una variable, nada de que strings, int ,float,void
                            /// nada de eso

using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

/// <summary>
///
/// opensource lima code
///
/// el codigo del lenguaje y del interpete
///
/// ejemplos
/// 
/// hello.lima:
///     echo "Hello World"
///    
/// 
/// fat12.lima
/// 
/// # las llamadas al sistema de archivos
///[intersegmental]
///message fat12::action
///
///# verificar si queremos cargar el sistema de archivos
///var
///    .cnd
///    =
///    (@ScratchVar(_action)=="0x01")
///
///# si es verdad saltar a la accion 0
///jt
///    0
///
///__endprog__
///
///# 0 (load fs)
///# 
///# Resumen:
///# 	cargar el sistema de archvios
///# 
///section
///0
///    # saltar al main del fs
///    jump
///    0.Main
///
///    # indicar que se estan cargando los archivos
///    echo "loading files..."
///
///    # only vfat12 , the subdirs cant be load
///
///    # this loads the files of your real pc in the path where is the uefi executable and coppy it to the
///    # Z hard disk
///
///    # Main
///    # 
///    # Resumen:
///    # 	la copia
///    # 
///    # Params:
///    # 	@(your files in the fd dir): para copiar al disco virtual
///    #   @(obiusly your personal files if you want): pero es necesario para que puedas cargar los archivos
///    # 
///    section
///    0.Main
///        # nota : cualquier cambio hecho no se guardara por que hace una copia en memoria
///        .
///        var
///            file_to_load
///            =
///            0
///
///        #
///        # obtener los archivos en la carpeta actual
///        #
///
///        mov
///            @eax
///            "/dir countf"
///
///        # enviar el comando
///        %^"!p"
///
///        # establezer loa archivos maximos a cargar
///        var
///            max_files
///            =
///            @ScratchVar(_returned)
///
///        # ir al primer elemento del array (0)
///        var
///            max_files
///            -=
///            1
///
///        # ir a la accion
///        jump
///        0.load
///
///    __endprog__
///
///    # load
///    # 
///    # Resumen:
///    # 	carga los archivos al sistema
///    # 
///    # Params:
///    # 	@max_files: la cantidad maxima de archivos
///    #   @file_to_load: el punto de entrada (la variable del archivo actual)
///    # 
///    section
///    0.load
///
///        #
///        # declarar las variables
///        #
///
///        var
///            name
///            =
///            prototype
///
///        var
///            content
///            =
///            prototype
///
///        #
///        # obtener la infformacion del archivo
///        #
///
///        # nombre de archivo
///
///        # ajustar el comando a el comando para obtener el nombre
///        mov
///            @eax
///            "/file_gName"
///
///        # el item del archivo
///        mov
///            @bx
///            file_to_load
///
///        # mandar el comando
///        %^"!p"
///
///        # hacer la copia
///        var
///            name
///            =
///            @ScratchVar(_returned)
///
///        # contenido del archivo
///        
///        # ajustar el comando a el comando para obtener el contenido
///        mov
///            @eax
///            "/file_gContent"
///
///        # el item del archivo
///        mov
///            @bx
///            file_to_load
///
///        # mandar el comando
///        %^"!p"
///
///        # hacer una copia
///        var
///            content
///            =
///            @ScratchVar(_returned)
///
///        #
///        # crear el archivo
///        #
///
///        # ahora si crearlo
///        movq
///            "fs0->"(..)name
///            content
///
///        #echo name(..)": "
///        #echo content
///
///        # verificar el archivo y cual es
///        #echo "file ""(..)name(..)"" has been loaded."
///
///        # ajustar la variable de condiciones para ver si supero los archivos maximos
///        var
///            .cnd
///            =
///            (file_to_load==max_files)
///
///        # siguiente archivo
///        var
///            file_to_load
///            +=
///            1
///
///        # si no lo supero cargar el siguiente archivo
///        jf
///            0.load
///            # next file
///
///    # si ya se cargaron todos detener el proceso
///    __endprog__
///[endmsg]
/// 
/// 
/// estructuras.lima
/// 
///     @structure
///     {
///         prototype
///         int
///         var
///             Salarios
///            
///         prototype
///         int
///         var
///             EmpleadosMaximos
///            
///         prototype
///         bool
///         var
///             EsTrabajoFisico
///             
///     }
///     Job_t
///     ;
///     
///     @structure
///     {
///         prototype
///         string
///         var
///             Nombre
///         
///         prototype
///         int
///         var
///             Edad
///         
///         prototype
///         Job_t
///         use_struct
///             Trabajo
///     }
///     Person
///     ;
/// 
/// </summary>
namespace Lima_LimaPlusPlus_interpreter
{
    /// <summary>
    /// 
    /// Lima
    /// 
    /// The interpreter class
    /// of the languaje lima
    /// 
    /// </summary>
    class Lima
    {
        /// <summary>
        /// 
        /// Lima variables
        /// 
        /// el diccionario de las variables del interprete
        /// 
        /// ejemplos:
        ///     
        ///     # esto modifica una variable
        ///     var
        ///         MiVariable
        ///         =
        ///         10
        ///         
        /// </summary>
        public Dictionary<LimObj, LimObj> lima_variables    = new Dictionary<LimObj, LimObj>();

        /// <summary>
        /// 
        /// globvars
        /// 
        /// las variables globales
        /// 
        /// ejemplo:
        /// 
        ///     # esto edita una variable global
        ///     mov
        ///         MyGlobalVar
        ///         10
        ///         
        /// </summary>
        public Dictionary<LimObj, LimObj> globvars          = new Dictionary<LimObj, LimObj>();

        /// <summary>
        /// 
        /// line_to_execute
        /// 
        /// la linea actual a ejecutar
        /// importante para la ejecucion del script
        /// 
        /// </summary>
        public int Line_to_execute                          = 0; 

        /// <summary>
        /// 
        /// popback
        /// 
        /// la pila (stack) para volver a un punto anterior con la instruccion popback
        /// 
        /// </summary>
        public Dictionary<int, int> popback                 = new Dictionary<int, int>();

        /// <summary>
        /// 
        /// segments
        /// 
        /// para poner mensjaes que se pueden llamar luego desde otro script
        /// 
        /// ejemplos
        ///     org
        ///     32
        ///     # guardar el script en el segemento 32
        ///     
        ///     [intersegmental]
        ///     message MiMensaje()
        ///     
        ///         echo "hello world"
        /// 
        ///     [endmsg]
        /// 
        /// en otro script:
        /// 
        ///     sendmw MiMensaje()
        /// 
        /// </summary>
        public Dictionary<int, LimObj> segments             = new Dictionary<int, LimObj>();

        /// <summary>
        /// 
        /// LimaPlusPlus
        /// 
        /// el bool que verifica si estas usando lima++
        /// 
        /// </summary>
        public bool LimaPlusPlus                            = false;

        /// <summary>
        /// 
        /// !SOLO EN LIMA++!
        /// 
        /// HaveMain
        /// 
        /// si el programa tiene un punto main
        /// 
        /// </summary>
        public bool HaveMain                                = false;

        /// <summary>
        /// 
        /// MySefCode
        /// 
        /// donde se guarda el codigo que se esta corriendo
        /// 
        /// </summary>
        public string MySefCode                             = "";

        /// <summary>
        /// 
        /// !SOLO EN LIMA++!
        /// 
        /// ReturnedValue
        /// 
        /// el valor retornado desde un collection function
        /// 
        /// </summary>
        public LimObj ReturnedValue                         = "";

        /// <summary>
        /// 
        /// StringToColor
        /// 
        /// el parse que paseara lo que tiene que parsear
        /// 
        /// </summary>
        public ConsoleColor
            StringToColor
            (
                string color_code
            )
        {
            ///
            /// negro
            ///
            if (color_code == "0")return ConsoleColor.Black;

            ///
            /// azul oscuro
            ///
            if (color_code == "1")return ConsoleColor.DarkBlue;

            ///
            /// verde oscuro
            ///
            if (color_code == "2") return ConsoleColor.DarkGreen;

            ///
            /// cian oscuro
            ///
            if (color_code == "3") return ConsoleColor.DarkCyan;
            
            ///
            /// rojo oscuro
            ///
            if (color_code == "4") return ConsoleColor.DarkRed; 

            ///
            /// magenta oscuro
            ///
            if (color_code == "5") return ConsoleColor.DarkMagenta;

            ///
            /// amarillo oscuro
            ///
            if (color_code == "6") return ConsoleColor.DarkYellow;

            ///
            /// gris
            ///
            if (color_code == "7") return ConsoleColor.Gray;

            ///
            /// gris oscuro
            ///
            if (color_code == "8") return ConsoleColor.DarkGray;

            ///
            /// azul
            ///
            if (color_code == "9") return ConsoleColor.Blue;

            ///
            /// verde
            ///
            if (color_code.ToUpper() == "A") return ConsoleColor.Green;

            ///
            /// cian
            ///
            if (color_code.ToUpper() == "B") return ConsoleColor.Cyan;

            ///
            /// rojo
            ///
            if (color_code.ToUpper() == "C") return ConsoleColor.Red;

            ///
            /// magenta
            ///
            if (color_code.ToUpper() == "D") return ConsoleColor.Magenta;

            ///
            /// amarillo
            ///
            if (color_code.ToUpper() == "E") return ConsoleColor.Yellow;

            ///
            /// blanco
            ///
            if (color_code.ToUpper() == "F") return ConsoleColor.White;

            ///
            /// si nada es igual (exactamente cuando te terminaron de un dia para
            /// el otro) retornar gris
            ///
            return ConsoleColor.Gray;
        }

        /// <summary>
        /// 
        /// AskForMessageIntoSegment
        /// 
        /// Preguntar por un mensaje en todos los segmentos y obtener el codigo
        /// 
        /// </summary>
        /// <param name="msg">
        ///     el mensaje a buscar
        /// </param>
        /// <returns></returns>
        public string
            AskForMessageIntoSegment
            (
                LimObj msg
            )
        {
            ///
            /// el array de los mensajes
            ///
            KeyValuePair<int,string>[] rmseg = segments.ToArray();

            ///
            /// buscar en todos los segmentos
            ///
            for (int i = 0; i < rmseg.Length; i++)
            {
                ///
                /// veficar si el segmento contiene el mensjae
                ///
                if (
                    rmseg[i].Value.Contains("[intersegmental]\nmessage " + msg)
                    )
                {
                    ///
                    /// obtener el codigo
                    ///
                    string[] sr = rmseg[i].Value.Split("[intersegmental]\nmessage " + msg);
                    string[] ara_ara = sr[1].Split("\n[endmsg]");

                    ///
                    /// obtener el mensaje
                    ///
                    return ara_ara[0];
                }
            }

            ///
            /// si no lo encontro obtener NULL
            ///
            return "";
        }

        /// <summary>
        /// 
        /// LimaSyntax
        /// 
        /// la sintaxis del lenguaje
        /// 
        /// ejemplos
        /// 
        ///     statement(..)statement2
        ///     (Valor1 operador Valor2)
        ///     "texto"
        ///     &variable
        ///     Scratch.(x)
        ///     @ScratchVar(variable global)
        ///     nullptr
        ///     NULL
        ///     ReadKeyWait
        ///     ReadLine
        ///     instancia(->)accion
        ///     
        /// </summary>
        /// <param name="e">
        /// la sintaxis con la cual trabajar
        /// </param>
        /// <param name="debug">
        /// el programa esta en modo depuracion?
        /// </param>
        /// <returns></returns>
        public LimObj
        LimaSyntax
        (
        LimObj e,
        bool debug
        )
        {
            ///
            /// juntar sintaxis
            ///
            if (
                    e.Contains("(..)")
                    )
            {
                ///
                /// las sinataxis a juntar
                ///
                string[] split = e.Split("(..)");

                /// la sintaxis que se formara
                string syntax = "";

                ///
                /// juntar todas las sintaxis
                ///
                foreach (var item in split)
                {
                    syntax += LimaSyntax(item, debug); /// juntarla
                }

                /// retornar el valor
                return syntax;
            }
            ///
            /// condicionales
            ///
            else if (
                e.StartsWith("(") && e.EndsWith(")")
                )
            {
                ///
                /// el operador 1 y el 2
                ///

                string ifcond = e.Substring(1, e.Length - 2);

                ///
                /// == (es equivalente)
                ///
                if (
                    ifcond.Contains("==")
                    )
                {
                    ///
                    /// separar por valor 1 y valor 2
                    ///
                    string[] split = ifcond.Split("==");

                    ///
                    /// comparar el valor 1 y el 2
                    ///
                    if (
                        LimaSyntax(split[0], debug) == LimaSyntax(split[1], debug)
                        )
                    {
                        ///
                        /// true
                        ///
                        return "true";
                    }
                    else
                    {
                        ///
                        /// false
                        ///
                        return "false";
                    }
                }

                ///
                /// != (no es equivalente)
                ///
                if (
                    ifcond.Contains("!=")
                    )
                {
                    ///
                    /// separar por valor 1 y valor 2
                    ///
                    string[] split = ifcond.Split("!=");

                    ///
                    /// comparar el valor 1 y el 2
                    ///
                    if (
                        LimaSyntax(split[0], debug) != LimaSyntax(split[1], debug)
                        )
                    {
                        ///
                        /// verdadero
                        ///
                        return "true";
                    }
                    else
                    {
                        ///
                        /// falso
                        ///
                        return "false";
                    }
                }

                ///
                /// si no es valido retornal falso
                ///
                return "false";
            }

            ///
            /// cadenas
            ///
            else if (
                    e.StartsWith("\"") && e.EndsWith("\"")
                    )
            {
                /// retornar el texto despues de los ""
                return e.Substring(1, e.Length - 2);
            }

            ///
            /// yo mismo
            ///
            else if (
                e == "@myself"
                )
            {
                return MySefCode;
            }

            ///
            /// obtener variable
            ///
            else if (
                lima_variables.ContainsKey(e)
                )
            {
                ///
                /// retornar el valor de la variable
                ///
                return lima_variables[e];
            }

            ///
            /// obtencio de variables globales automaticamente (solo Lima++)
            /// esto esta solo en Lima++ para mantener compatibilidad con la version de turbowarp
            ///
            else if
                (
                globvars.ContainsKey(e) && LimaPlusPlus
                )
            {
                ///
                /// retornar el valor de la variable global
                ///
                return globvars[e];
            }

            ///
            /// obtener direccion del puntero a una variable
            ///
            else if (
                e.StartsWith('&')
                    )
            {
                ///
                /// devolver la direccion de la variable
                ///
                return e.Substring(1);
            }

            ///
            /// obtener el año
            ///
            else if (
                e == "Scratch.GetYear"
                )
            {
                ///
                /// retornarlo
                ///
                return (DateTime.Now.Year).ToString();
            }

            ///
            /// obtener el mes
            ///
            else if (
                e == "Scratch.GetMonth"
                )
            {
                ///
                /// retornarlo
                ///
                return (DateTime.Now.Month).ToString();
            }

            ///
            /// obtener el dia
            ///
            else if (
                e == "Scratch.GetDay"
            )
            {
                ///
                /// retornarlo
                ///
                return (DateTime.Now.Day).ToString();
            }

            ///
            /// obtener la hora
            ///
            else if (
                e == "Scratch.GetHour"
                )
            {
                ///
                /// retornarlo
                ///
                return (DateTime.Now.Hour).ToString();
            }

            ///
            /// obtener el minuto
            ///
            else if (
                e == "Scratch.GetMinute"
                )
            {
                ///
                /// retornarlo
                ///
                return (DateTime.Now.Minute).ToString();
            }

            ///
            /// obtener el line feed
            ///
            else if (
                e == "string.linefeed"
                )
            {
                ///
                /// retornarlo
                ///
                return "\n";
            }

            ///
            /// obtener el segundo
            ///
            else if (
                e == "Scratch.GetSecond"
                )
            {
                ///
                /// retornarlo
                ///
                return (DateTime.Now.Second).ToString();
            }
            
            ///
            /// obtener una variable global
            ///
            else if (
                e.StartsWith("@ScratchVar(")
            )
            {
                ///
                /// extraer el nombre de la variable
                ///
                string er = e.Substring(12, e.Length - 13);

                ///
                /// normalize
                ///
                er = LimaSyntax(er,debug);

                ///
                /// verificar si existe
                ///
                if (
                globvars.ContainsKey(er)
                )
                    return globvars[er]; /// si existe obtenerla
                
                return ""; /// si no existe devolver null
            }

            ///
            /// puntero nulo
            ///
            else if (e == "nullptr")
            {
                ///
                /// retornarlo
                ///
                return "";
            }

            ///
            /// inexistencia
            ///
            else if (e == "NULL")
            {
                ///
                /// retornarlo
                ///
                return "";
            }

            ///
            /// depurando?
            ///
            else if (
                e == "@debug"
                )
            {
                ///
                /// retornarlo
                ///
                return debug.ToString();
            }

            ///
            /// lineas de la consola
            ///
            else if (
                e == "Console.Lines"
                )
            {
                ///
                /// retornarlo
                ///
                
                return Console.WindowHeight.ToString();
            }

            ///
            /// leer una tecla y esperar
            ///
            else if (
                e == "ReadKeyWait"
                )
            {
                ///
                /// obtener la tecla
                ///
                ConsoleKeyInfo key = Console.ReadKey(true);

                ///
                /// flecha arriba
                ///
                if
                    (
                    key.Key == ConsoleKey.UpArrow
                    )
                    ///
                    /// retornarlo
                    ///
                    return "up arrow";


                ///
                /// flecha abajo
                ///
                if
                    (
                    key.Key == ConsoleKey.DownArrow
                    )
                    ///
                    /// retornarlo
                    ///
                    return "down arrow";


                ///
                /// flecha izquiera (creo)
                ///
                if
                    (
                    key.Key == ConsoleKey.LeftArrow
                    )
                    ///
                    /// retornarlo
                    ///
                    return "left arrow";


                ///
                /// flecha derecha
                ///
                if
                    (
                    key.Key == ConsoleKey.RightArrow
                    )
                    ///
                    /// retornarlo
                    ///
                    return "right arrow";


                ///
                /// tabulador
                ///
                if
                    (
                    key.Key == ConsoleKey.Tab
                    )
                    ///
                    /// retornarlo
                    ///
                    return "tab";


                ///
                /// escape
                ///
                if
                    (
                    key.Key == ConsoleKey.Escape
                    )
                    ///
                    /// retornarlo
                    ///
                    return "escape";


                ///
                /// borrar
                ///
                if
                    (
                    key.Key == ConsoleKey.Backspace
                    )
                    ///
                    /// retornarlo
                    ///
                    return "backspace";


                ///
                /// entrar
                ///
                if (
                    key.Key == ConsoleKey.Enter
                    )
                    ///
                    /// retornarlo
                    ///
                    return "enter";

                ///
                /// funcion cerrar
                ///
                if
                    (
                    key.Key == ConsoleKey.X && key.Modifiers == ConsoleModifiers.Control
                    )
                    ///
                    /// retornarlo
                    ///
                    return "close function";

                ///
                /// undo
                ///
                if
                    (
                    key.Key == ConsoleKey.Z && key.Modifiers == ConsoleModifiers.Control
                    )
                    ///
                    /// retornarlo
                    ///
                    return "undo";

                ///
                /// redo
                ///
                if
                    (
                    key.Key == ConsoleKey.Y && key.Modifiers == ConsoleModifiers.Control
                    )
                    ///
                    /// retornarlo
                    ///
                    return "redo";

                ///
                /// retornar la tecla si nada es valido
                ///
                return key.KeyChar.ToString();
            }

            ///
            /// leer la linea entrada por el usuario
            ///
            else if (
                e == "ReadLine"
                )
            {
                string em = Console.ReadLine();

                Thread.Sleep(50);

                ///
                /// retornarlo
                ///
                return em == null ? "" : em;
            }

            ///
            /// hacer algo con una sintaxis
            ///
            else if
                (
                    e.Contains("(->)")
                )
            {
                if (
                    e.StartsWith("collection<")
                    )
                {
                    if
                        (
                        !LimaPlusPlus
                        ) {
                        return "you need Lima++ for this feature";
                    }

                    ///
                    /// dividirlo en lima++ y accion
                    ///

                    string[] split = e.Split("(->)");

                    string parametres = (split[0].Substring(11, split[0].Length - 12));

                    string[] paramsxd = parametres.Split(";");

                    ///
                    /// parse
                    ///

                    if (
                        paramsxd[0] == "instance"
                        )
                    {
                        ///
                        /// verificar el tipo de instancia
                        ///

                        string[] instance_type = paramsxd[1].Split("?");

                        if (
                            instance_type[0] == "class"
                            )
                        {
                            ///
                            /// encontrar la class
                            ///

                            string class_find = instance_type[1] + "->class";

                            ///
                            /// el cuerpo de la funcion y de la class
                            ///

                            string class_body = lima_variables[class_find];

                            string function_body = class_body.Split("collection<function " + paramsxd[3] + ">")[1];
                            
                            function_body = function_body.Split("collection<end function>")[0];

                            ///
                            /// descomponer attributos
                            ///

                            string[] attributes = split[1].Substring(1, split[1].Length - 2).Split(",");

                            int attributes_cout = attributes.Length;

                            ///
                            /// parsear attributos
                            ///

                            string[] function_bod_lines = function_body.Replace("\r","").Split("\n");

                            string[] function_params = new string[210];

                            int attriubute_check = 0;
                            int blocks_number = 0;
                            int param_count = 0;

                            while (
                                true
                                )
                            {
                                if (
                                    function_bod_lines[attriubute_check].Trim() == ")"
                                    )
                                {
                                    blocks_number -= 1;
                                    if (
                                        blocks_number == 0)
                                        break;
                                }
                                else if (
                                    function_bod_lines[attriubute_check].Trim() == "("
                                    )
                                {
                                    blocks_number += 1;
                                }
                                else if (
                                    function_bod_lines[attriubute_check].StartsWith("collection<param ")
                                    )
                                {
                                    string paramm = function_bod_lines[attriubute_check].Substring(17, function_bod_lines[attriubute_check].Length - 18);

                                    function_params[param_count] = paramm;

                                    param_count++;
                                }

                                attriubute_check++;
                            }

                            ///
                            /// renplazar los parametros y normalizar funcion
                            ///

                            for (int i = 0; i < param_count; i++)
                            {
                                function_body = function_body.Replace("collection<param " + function_params[i] + ">", attributes[i].Replace("%sp", " ").Replace("%cm",","));
                            }

                            //Console.WriteLine(function_body.Contains("collection<get __value>").ToString());

                            function_body = function_body.Replace("collection<get __value>", paramsxd[2]);
                            function_body = function_body.Replace("(this)", paramsxd[2]);

                            ///
                            /// recuperacion de variables
                            ///
                            int line_to = Line_to_execute;
                            Dictionary<int, int> recover_popback = popback;

                            ///
                            /// ejecutar la funcion
                            ///
                            Line_to_execute = 0;
                            ExecuteLimaScript(function_body, debug);

                            ///
                            /// recuperara los valores anteriores
                            ///
                            Line_to_execute = line_to + 1;

                            popback = recover_popback;

                            return ReturnedValue;

                        }
                    }
                }
                else
                {

                    ///
                    /// dividirlo en valor y accion
                    ///
                    string[] split = e.Split("(->)");

                    ///
                    /// si se quiere obtener un item
                    ///
                    if (
                        split[1].StartsWith("[") &&
                        split[1].EndsWith("]")
                        )
                    {
                        ///
                        /// obtener el valor entre corchetes
                        ///
                        string item = split[1].Replace("[", "");
                        item = item.Replace("]", "");

                        ///
                        /// obtener el array
                        ///
                        string[] array = lima_variables[split[0]].Replace("\r", "").Split("\n");

                        ///
                        /// verificar si la longitud es menor
                        ///
                        if (array.Length > Convert.ToInt32(LimaSyntax(item, debug)))

                            ///
                            /// retornarlo
                            ///
                            return array[Convert.ToInt32(LimaSyntax(item, debug))];

                        ///
                        /// si es cierto retornar NULL
                        ///
                        return "";
                    }
                    else if
                        (
                        split[1].StartsWith("StartsWith ") && split[1].Length > 11
                        )
                    {
                        ///
                        /// obtener el statment
                        ///
                        LimObj statmente = split[1].Replace("StartsWith ", "");

                        ///
                        /// verificar si es true
                        ///
                        if (
                            lima_variables[split[0]].StartsWith(LimaSyntax(statmente, debug))
                            )
                        {
                            return "true";
                        }

                        ///
                        /// si no
                        ///
                        return "false";
                    }
                }
            }

            ///
            /// si nada es valido devolver la sintaxis
            ///
            return e;
        }

        /// <summary>
        /// 
        /// VariablesSyntax
        /// 
        /// la sintaxis de las variables
        /// 
        /// ejemplos
        ///     varnmae
        ///     get -> sintaxis
        /// 
        /// </summary>
        /// <param name="varname">
        ///     el nombre de la variable o el statemiento
        /// </param>
        /// <returns></returns>
        public string
            VariablesSyntax
            (
            string varname
            )
        { 
            if (
                varname.StartsWith("get -> ")
                )
            {
                return LimaSyntax(varname.Substring(7, varname.Length - 7), false);
            }

            return varname;
        }

        /// <summary>
        /// 
        /// Execute
        /// 
        /// ejecutar un comando
        /// 
        /// ejemplo:
        ///     echo "hola mundo"
        /// 
        /// </summary>
        /// <param name="e">
        /// el comando
        /// </param>
        /// <param name="debug">
        /// si estan depurando
        /// </param>
        public void
            Execute
            (
            LimObj e,
            bool debug
            )
        {
            ///
            /// comando echo
            ///
            if (e.StartsWith("echo "))
            {
                ///
                /// imprimir el texto
                ///
                Console.WriteLine(LimaSyntax(e.Substring(5, e.Length - 5), debug));
            }

            ///
            /// comando cecho (imprimir texto en el centro de la pantalla)
            ///
            else if (e.StartsWith("cecho "))
            {
                ///
                /// obtener el texto
                ///
                LimObj texto = LimaSyntax(e.Substring(6, e.Length - 6), debug);

                ///
                /// calcular la pocision
                ///
                int x = (Console.WindowWidth - texto.Length) / 2; /// Calcula la posición horizontal
                int y = Console.WindowHeight / 2; /// Calcula la posición vertical

                ///
                /// para restaurar la posicion luego
                ///
                int oldx = Console.CursorLeft;
                int oldy = Console.CursorTop;

                ///
                /// imprimir el texto
                ///
                Console.SetCursorPosition(x, y); /// Mueve el cursor al centro
                Console.WriteLine(texto);

                ///
                /// restaurar la posicion
                ///
                Console.CursorLeft = oldx;
                Console.CursorTop = oldy;
            }

            ///
            /// button_echo (imprimir un texto centrado en la parte de abajo de la pantalla)
            ///
            else if (e.StartsWith("button_echo "))
            {
                ///
                /// obtener texto
                ///
                LimObj texto = LimaSyntax(e.Substring(12, e.Length - 12), debug);

                ///
                /// calcular la posicion
                ///
                int x = (Console.WindowWidth - texto.Length) / 2; /// Calcula la posición horizontal
                int y = Console.WindowHeight - 1; /// Calcula la posición vertical

                ///
                /// para restaurarlo luego
                ///
                int oldx = Console.CursorLeft;
                int oldy = Console.CursorTop;

                ///
                /// imprimir el texto
                ///
                Console.SetCursorPosition(x, y); /// Mueve el cursor al centro
                Console.WriteLine(texto);

                ///
                /// restaurar la posicion
                ///
                Console.CursorLeft = oldx;
                Console.CursorTop = oldy;
            }

            ///
            /// prototipear modulos
            ///
            else if (e.StartsWith("proto module "))
            {
                lima_variables[e.Substring(13, e.Length - 13) + "->module"] = "";
            }

            ///
            /// comando del interprete
            ///
            else if (e == "%^\"!p\"")
            {
                ///
                /// esto lo que hace es enviar un comando al interprete
                /// obiamente no se puede hacer todo en lima y se necesitan funciones minimas
                ///

                ///
                /// obtener el nombre del archivo
                ///
                if (
                   globvars["@eax"] == "/file_gName"
                    )
                {
                    ///
                    /// obtener la lista de archivos
                    ///
                    IEnumerable<LimObj> names = Directory.EnumerateFiles(globvars["@dircurrent"]);

                    ///
                    /// obtenerlo ya en array
                    ///
                    LimObj[] nrt = names.ToArray();

                    ///
                    /// devolver el valor
                    ///
                    globvars["_returned"] = Path.GetFileName(nrt[Convert.ToInt32(globvars["@bx"])]);
                }

                ///
                /// obtener todas las variables que inicen con
                ///
                else if (
                    globvars["@eax"] == "/glob -gtv -array_startswith"
                    )
                {
                    ///
                    /// el array
                    ///
                    LimObj array = "";

                    ///
                    /// buscar las variables
                    ///
                    foreach (var item in globvars.ToArray())
                    {
                        if (item.Key.StartsWith(globvars["@bx"])) array += item + "\n";
                    }

                    ///
                    /// devolver el valor
                    ///
                    globvars["_returned"] = array;
                }

                ///
                /// obtener cuantos archivos hay en la carpeta actual donde se esta ejecutnado el script
                ///
                else if (
                    globvars["@eax"] == "/dir countf"
                    )
                {
                    ///
                    /// obtener los archivos
                    ///
                    IEnumerable<LimObj> names = Directory.EnumerateFiles(globvars["@dircurrent"]);

                    ///
                    /// obenere el array normalizado
                    ///
                    string[] nrt = names.ToArray();

                    ///
                    /// devolver cuantos archivos tiene
                    ///
                    globvars["_returned"] = nrt.Length.ToString();
                }

                ///
                /// obtener el contenido de un archvio
                ///
                else if (
                   globvars["@eax"] == "/file_gContent"
                    )
                {
                    ///
                    /// obtener la lista de archivos
                    ///
                    IEnumerable<LimObj> names = Directory.EnumerateFiles(globvars["@dircurrent"]);

                    ///
                    /// obtener los nombres
                    ///
                    LimObj[] nrt = names.ToArray();

                    ///
                    /// obtener el contenido
                    ///
                    globvars["_returned"] = File.ReadAllText(nrt[Convert.ToInt32(globvars["@bx"])]);
                }

                ///
                /// separar un texto en elementos
                ///
                else if (
                   globvars["@eax"] == "/string split"
                    )
                {
                    ///
                    /// el array
                    ///
                    LimObj array = globvars["@ax"];

                    ///
                    /// separarlo en elementos
                    ///
                    array = array.Replace(globvars["@bx"], "\n");

                    ///
                    /// retornarlo
                    ///
                    globvars["_returned"] = array;
                }

                ///
                /// obtener el contenido de una pagina web
                ///
                else if (
                    globvars["@eax"] == "/get-url"
                    )
                {
                    /*
                    ///
                    /// obtener la url
                    ///
                    LimObj url = globvars["@bx"];

                    ///
                    /// intentar obtener datos
                    ///
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            /// Enviar una solicitud GET y obtener la respuesta
                            HttpResponseMessage response = await client.GetAsync(url);

                            /// Asegurarse de que la solicitud fue exitosa
                            response.EnsureSuccessStatusCode();

                            /// Leer el contenido de la respuesta como una cadena
                            LimObj content = await response.Content.ReadAsStringAsync();

                            ///
                            /// retornar el valor
                            ///
                            globvars["_returned"] = content;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    */
                }

                ///
                /// verificar si un array tiene un elemento
                ///
                else if (
                    globvars["@eax"] == "/array ContainsValue"
                    )
                {
                    if (
                        globvars["@bx"].Contains(globvars["@ax"] + "\n")
                        )
                    {
                        globvars["_returned"] = "true";
                    }
                    else
                    {
                        globvars["_returned"] = "false";
                    }
                }

                ///
                /// obtener la cantidad de entradas del array
                ///
                else if (
                    globvars["@eax"] == "/array icount"
                    )
                {
                    int count = globvars["@bx"].Split('\n').Length;

                    globvars["_returned"] = count.ToString();
                }

                ///
                /// añadir al array
                ///
                else if (
                    globvars["@eax"] == "/array Add"
                    )
                {
                    globvars["_returned"] += globvars["@bx"] + globvars["@ax"] + "\n";
                }

                ///
                /// escribir un archivo
                ///
                else if (
                    globvars["@eax"] == "/file_write"
                    )
                {
                    string file_to_save = Path.Join(globvars["@dircurrent"], globvars["@bx"]);

                    if (
                        !File.Exists(file_to_save)
                        )
                    {
                        File.Create(file_to_save);
                    }

                    File.WriteAllText(file_to_save, globvars["@ax"]);
                }

                ///
                /// obtener el contenido de un archivo , por su nombre
                ///

                else if (
                    globvars["@eax"] == "/file getconent -n"
                    )
                {
                    string file_to_load = Path.Join(globvars["@dircurrent"], globvars["@bx"]);

                    if (
                        File.Exists(file_to_load))
                    {
                        globvars[ReturnedValue] = File.ReadAllText(file_to_load);
                    }
                    else
                    {
                        globvars[ReturnedValue] = "??wtf??";
                    }
                }
            }

            ///
            /// escribir en linea
            ///
            else if (e.StartsWith("writel "))
            {
                ///
                /// imprimir el texto en la misma linea
                ///
                Console.Write(LimaSyntax(e.Substring(7, e.Length - 7), debug));
            }

            ///
            /// ejecutar codigo lima desde otro lima xD
            ///
            else if (e.StartsWith("lex "))
            {

                ///
                /// recuperacion de variables
                ///
                int line_to = Line_to_execute;
                Dictionary<int, int> recover_popback = popback;

                ///Console.WriteLine(e);

                ///
                /// ejecutar el mensaje
                ///
                Line_to_execute = 0;
                ExecuteLimaScript(LimaSyntax(e.Substring(4, e.Length - 4), debug), debug);

                ///
                /// recuperara los valores anteriores
                ///
                Line_to_execute = line_to + 1;

                popback = recover_popback;
            }

            ///
            /// cambiar el color
            ///
            else if (e.StartsWith("color "))
            {
                ///
                /// obtener los parametros
                ///
                LimObj er = e.Substring(6, e.Length - 6);

                ///
                /// obtener la lista
                ///
                LimObj[] colors = er.Split(" ");

                ///
                /// obtener el texto y el fondo
                ///

                LimObj foreground = LimaSyntax(colors[0], debug);

                LimObj background = LimaSyntax(colors[1], debug);

                ///
                /// ajustar los colores
                ///

                Console.BackgroundColor = ConsoleColor.Black;
                Console.BackgroundColor += int.Parse(background);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.ForegroundColor += int.Parse(foreground);

            }

            ///
            /// para hacer un pitido
            ///
            else if (e.StartsWith("beep "))
            {
                ///
                /// obtener los parametros
                ///
                LimObj er = e.Substring(5, e.Length - 5);

                ///
                /// obtener la lista
                ///
                LimObj[] colors = er.Split(" ");

                ///
                /// obtener el texto y el fondo
                ///

                LimObj freq = LimaSyntax(colors[0], debug);

                LimObj duration = LimaSyntax(colors[1], debug);

                ///
                /// hacer un pitido
                ///

#if WINDOWS
                Console.Beep(int.Parse(freq), int.Parse(duration));
#endif
            }

            ///
            /// ir a una posicion
            ///
            else if (e.StartsWith("gotoxy "))
            {
                ///
                /// obtener los parametros
                ///
                LimObj er = e.Substring(7, e.Length - 7);

                ///
                /// obtener la lista
                ///
                LimObj[] colors = er.Split(" ");

                ///
                /// obtener el texto y el fondo
                ///

                LimObj cursorx = LimaSyntax(colors[0], debug);

                LimObj cursory = LimaSyntax(colors[1], debug);

                ///
                /// ajustar la pocision
                ///

                Console.SetCursorPosition(int.Parse(cursorx), int.Parse(cursory));

            }

            ///
            /// mandar un mensaje intersegmental
            ///
            else if (
                e.StartsWith("sendmw ")
                )
            {
                ///
                /// recuperacion de variables
                ///
                int line_to = Line_to_execute;
                Dictionary<int, int> recover_popback = popback;

                ///Console.WriteLine(e);

                ///
                /// ejecutar el mensaje
                ///
                Line_to_execute = 0;
                ExecuteLimaScript(AskForMessageIntoSegment(e.Substring(7, e.Length - 7)), debug);

                ///
                /// recuperara los valores anteriores
                ///
                Line_to_execute = line_to + 1;

                popback = recover_popback;
            }

            ///
            /// limpiar la pantalla
            ///
            else if (
                e == "cls"
                )
            {
                Console.Clear();
            }

            ///
            /// dormirse
            ///
            else if (
                e.StartsWith("sleep ")
                )
            {
                ///
                /// esperar esa cantidad de segundos
                ///
                Thread.Sleep(int.Parse(LimaSyntax(e.Substring(6, e.Length - 6), debug)) * 1000);
            }

            ///
            /// syntax statment
            ///
            else if (
                e.StartsWith("NULL ")
                )
            {
                string ar = LimaSyntax(e.Substring(5,e.Length - 5),debug);

                Console.Write(ar == "" ? ar : "");
            }

            return;
        }

        /// <summary>
        /// 
        /// Operate_With
        /// 
        /// operador de variables
        /// 
        /// ejemplos
        ///     =
        ///     +=
        ///     -=
        ///     *=
        ///     /=
        ///     %=
        ///     &=
        ///     |=
        ///     xor=
        /// 
        /// </summary>
        /// <param name="operator1"></param>
        /// <param name="a"></param>
        /// <param name="operator2"></param>
        /// <returns></returns>
        public LimObj
            Operate_With
            (
                LimObj operator1,
                LimObj a,
                LimObj operator2

            )
        {
            ///
            /// asignar
            ///
            if (a == "=") return operator2; /// the equal simbol

            ///
            /// StrCatear
            ///
            if (a == "StrCat=") return operator1 + operator2;

            ///
            /// sumar
            /// 
            if (a == "+=") /// the sum simbol
            {
                ///
                /// verificar si el operador1 es un texto o numero
                ///
                if (
                    int.TryParse(operator1, out int value1) == false /// if the operator1 is a text
                    )
                {
                    ///
                    /// si el operador2 es un numero recorrer el texto
                    ///
                    if (
                        int.TryParse(operator2, out int value2) /// if the operator2 is a number
                    )
                    {
                        return operator1.Substring(int.Parse(operator2), operator1.Length - int.Parse(operator2)); /// desplaze it
                    }

                    ///
                    /// si los dos son textos unirlos
                    ///
                    else
                    {
                        return operator1 + operator2; /// if not a number join the texts
                    }
                }

                ///
                /// sumarlo si no es cierto
                ///
                else
                {
                    return (int.Parse(operator1) + int.Parse(operator2)).ToString(); /// if a number the two sum it
                }
            }

            ///
            /// la resta
            ///
            if (a == "-=") /// the sub simbol
            {
                ///
                /// si el operador 1 es un texto
                ///
                if (
                    int.TryParse(operator1, out int value1) == false /// if the operator1 is a text
                    )
                {
                    ///
                    /// si el operador 2 es un numero recorrer el texto
                    ///
                    if (
                        int.TryParse(operator2, out int value2) /// if the operator2 is a number
                    )
                    {
                        return operator1.Substring(0, operator1.Length - int.Parse(operator2)); /// desplaze it
                    }

                    ///
                    /// eliminar todas las ocurrencias si es un numero el operador 2
                    ///
                    else
                    {
                        return operator1.Replace(operator2,""); /// if not a number return the operator 2
                    }
                }
                
                ///
                /// restarlo si los dos son numeros
                ///
                else
                {
                    return (int.Parse(operator1) - int.Parse(operator2)).ToString(); /// if a number the two sum it
                }
            }

            ///
            /// multiplicar
            ///
            if (a == "*=")
            {
                return (int.Parse(operator1) * int.Parse(operator2)).ToString();
            }

            ///
            /// dividir
            ///
            if (a == "/=")
            {
                return (int.Parse(operator1) / int.Parse(operator2)).ToString();
            }

            ///
            /// modulo
            ///
            if (a == "%=")
            {
                return (int.Parse(operator1) % int.Parse(operator2)).ToString();
            }

            ///
            /// and
            ///
            if (a == "&=")
            {
                return (int.Parse(operator1) & int.Parse(operator2)).ToString();
            }


            ///
            /// or
            ///
            if (a == "|=")
            {
                return (int.Parse(operator1) | int.Parse(operator2)).ToString();
            }


            ///
            /// xor
            ///
            if (a == "xor=")
            {
                return (int.Parse(operator1) ^ int.Parse(operator2)).ToString();
            }


            ///
            /// si nada es cierto , retornar el operador2 como ultimo recurso
            ///
            return operator2;
        }

        /// <summary>
        /// 
        /// ExecuteLimaScript
        /// 
        /// el centro de todo , la ejecucion del script
        /// 
        /// </summary>
        /// <param name="lscript">
        /// 
        /// lscript
        /// 
        /// representa el script que se esta ejecutando sin formatear, luego se les quita
        /// los molesto R hijos de su-
        /// 
        /// </param>
        /// <param name="debug">
        /// 
        /// debug
        /// 
        /// si el depurador esta activado durante la ejecucion del script
        /// 
        /// </param>
        public void
        ExecuteLimaScript
        (
            string lscript,
            bool debug
        )
        {
            /// 
            /// si esta en una estructura
            ///
            bool in_struct;

            ///
            /// quitar el char carrige que lo unico que hace aqui es molestar
            ///
            string script = lscript.Replace("\r", "");

            ///
            /// guardar el codigo
            ///

            MySefCode = script;

            ///
            /// separa el script en lineas
            ///
            string[] lines = script.Split(new[] { '\n' });

            ///
            /// bucle principal
            ///
            while (
                Line_to_execute < lines.Length
                )
            {
                ///Console.WriteLine(Line_to_execute.ToString() + ": " + lines[Line_to_execute]);

                ///
                /// instruccion de creacion de estructura
                ///
                if (
                    lines[Line_to_execute].Trim() == "@structure"
                    )
                {
                    ///
                    /// indicar que estamos en una estructura
                    ///
                    in_struct = true;

                    ///
                    /// la definicion
                    ///
                    string structuredefinition = "";

                    ///
                    /// emparejar estructura
                    ///
                    while (
                        lines[Line_to_execute].Trim() != "}"
                        )
                    {

                        ///
                        /// si declaramos algo
                        ///
                        if (
                            lines[Line_to_execute].Trim() == "prototype"
                            )
                        {
                            ///
                            /// si es una variable
                            ///
                            if (lines[Line_to_execute + 2].Trim() == "var")
                                structuredefinition = structuredefinition + lines[Line_to_execute + 1].Trim() + "|" + lines[Line_to_execute + 3].Trim() + "\n";
                            ///
                            /// si es un use_struct
                            ///
                            else if (lines[Line_to_execute + 2].Trim() == "use_struct")
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

                        ///
                        /// siguiente linea
                        ///
                        Line_to_execute++;
                    }

                    ///
                    /// salir de la estructura al nombre
                    ///
                    Line_to_execute++;

                    ///
                    /// asignar a la plantilla
                    /// 
                    lima_variables[lines[Line_to_execute].Trim()] = structuredefinition;

                    ///
                    /// ya no estamos en una estructura
                    ///
                    in_struct = false;
                    ///Console.WriteLine(structuredefinition);
                }

                ///
                /// establezer variable global
                ///
                else if (
                    (lines[Line_to_execute]).Trim() == "mov"
                )
                {
                    ///Console.WriteLine(Line_to_execute + 1.ToString() + ": " + lines[Line_to_execute + 1]);

                    globvars[(lines[Line_to_execute + 1]).Trim()] = LimaSyntax((lines[Line_to_execute + 2]).Trim(), debug);
                }

                ///
                /// expandir modulos
                ///
                else if
                    (
                    lines[Line_to_execute].Trim().StartsWith("expand module ")
                    )
                {
                    string module = lines[Line_to_execute].Trim().Substring(14, lines[Line_to_execute].Trim().Length - 14);
                    string linesa = "";

                    Line_to_execute += 2;

                    int blocks = 1;

                    while (blocks != 0)
                    {
                        linesa += lines[Line_to_execute] + "\n";

                        if (
                            lines[Line_to_execute].Trim() == "{"
                            )
                        {
                            blocks++;
                        }
                        else if (
                            lines[Line_to_execute].Trim() == "}"
                            )
                        {
                            blocks--;
                        }
                        Line_to_execute++;
                    }

                    lima_variables[module + "->module"] += linesa;
                }

                ///
                /// comentarios de varias lineas de Lima++
                ///
                else if (
                        lines[Line_to_execute].Trim().StartsWith("/**")
                    )
                {
                    if (
                        !lines[Line_to_execute].EndsWith("**/")
                        )
                    {
                        while (!lines[Line_to_execute].EndsWith("**/"))
                        {
                            Line_to_execute++;
                        }
                    }
                }

                ///
                /// las caracterizticas de Lima++
                ///
                else if
                    (
                        lines[Line_to_execute].Trim().StartsWith("collection")
                    )
                {
                    ///
                    /// configurar variables
                    ///

                    string mmmnk = lines[Line_to_execute].Trim();
                    string parameters = mmmnk.Substring(11, mmmnk.Length - 12);

                    ///
                    /// manejar parametros
                    ///
                    string[] paramsxd = parameters.Split(" ");

                    if (
                        LimaPlusPlus
                        )
                    {
                        ///
                        /// clases
                        ///
                        if (
                            paramsxd[0] == "class"
                            )
                        {
                            ///
                            /// configurar clase
                            ///

                            string class_name = paramsxd[1];
                            string class_body = "";
                            int blocks_number = 0;

                            ///
                            /// a la accion
                            ///

                            Line_to_execute += 2;
                            blocks_number = 1;
                            while (blocks_number != 0)
                            {
                                if (
                                    lines[Line_to_execute].Trim() == "{"
                                    )
                                    blocks_number++;

                                if (
                                    lines[Line_to_execute].Trim() == "}"
                                    ) {
                                    blocks_number--;
                                    break;
                                        }

                                class_body += lines[Line_to_execute].Trim() + "\n";

                                Line_to_execute++;

                            }

                            lima_variables[class_name + "->class"] = class_body;

                            Line_to_execute++;

                        }
                        
                        ///
                        /// palabra new
                        ///
                        else if (
                            paramsxd[0] == "new"
                            )
                        {
                            ///
                            /// parsear palabras
                            ///

                            string instancex = paramsxd[1];
                            string[] instance_body = instancex.Split("?");

                            ///
                            /// verificar que cuerpo se quiere definir
                            ///

                            ///
                            /// instancear una clase
                            ///
                            if (
                                instance_body[0] == "class"
                                )
                            {
                                string class_name = instance_body[1];

                                string class_solved = lima_variables[class_name + "->class"];

                                string instance_name = paramsxd[2];

                                if (
                                    lines[Line_to_execute + 1].Trim() == "="
                                    ) {
                                    lima_variables[instance_name + "->class_functions"] = class_solved;
                                    lima_variables[instance_name] = LimaSyntax(lines[Line_to_execute + 2].Trim(), debug);
                                }
                                else if (
                                    lines[Line_to_execute + 1].Trim() == "X="
                                    )
                                {
                                    lima_variables[instance_name + "->class_functions"] = LimaSyntax("NULL",debug);
                                    lima_variables[instance_name] = LimaSyntax("NULL", debug);
                                }

                            }
                        }

                        ///
                        /// retorno
                        ///

                        else if (
                            paramsxd[0] == "return"
                            )
                        {
                            ReturnedValue = LimaSyntax(paramsxd[1], debug);
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you need Lima++ to use collection");
                    }

                }

                ///
                /// propiedades del script
                ///
                else if (
                    lines[Line_to_execute].Trim().StartsWith("///! ")
                    )
                {
                    string propiety = lines[Line_to_execute].Trim().Substring(5, lines[Line_to_execute].Trim().Length - 5);
                    
                    if (
                        propiety.Trim() == "![enable Lima++]"
                        )
                        LimaPlusPlus = true;

                    if (
                        propiety.Trim() == "![disable Lima++]"
                        )
                        LimaPlusPlus = false;
                }

                ///
                /// establezer de valor con valor
                ///
                else if (
                    (lines[Line_to_execute]).Trim() == "movq"
                )
                {
                    ///Console.WriteLine(Line_to_execute + 1.ToString() + ": " + lines[Line_to_execute + 1]);

                    globvars[LimaSyntax((lines[Line_to_execute + 1]).Trim(),debug)] = LimaSyntax((lines[Line_to_execute + 2]).Trim(), debug);
                }

                ///
                /// usar una estructura
                ///
                else if (
                        (lines[Line_to_execute]).Trim() == "ustruct"
                    )
                {
                    ///
                    /// seleccionar los valores
                    ///
                    string var_set = lines[Line_to_execute + 1].Trim();
                    string structure = lines[Line_to_execute + 2].Trim();

                    if (
                        lima_variables.ContainsKey(structure)
                        )
                    {

                        ///
                        /// se que los usuarios queran buscar que estructura se utilizo
                        /// entonces la variable principal se ajustara como el nombre de la
                        /// estructura
                        ///
                        lima_variables[var_set] = structure;

                        ///
                        /// separar los miembros de la estructura
                        ///
                        string[] struct_use = lima_variables[structure].Split("\n");

                        ///
                        /// ajustar las variables
                        ///
                        foreach (var item in struct_use)
                        {
                            if (
                                item.Contains("|")
                                )
                            {
                                ///
                                /// valor|variable
                                ///
                                string[] value_key = item.Split("|");

                                ///
                                /// ajustar el nombre de la estructura
                                ///
                                //Console.WriteLine(var_set + "->" + value_key[1]);
                                //Console.WriteLine(LimaSyntax(value_key[0], debug));
                                lima_variables[var_set + "->" + value_key[1]] = LimaSyntax(value_key[0], debug);
                            }
                        }
                    }

                    ///
                    /// si no existe
                    ///
                    else
                    {
                        lima_variables[var_set] = LimaSyntax("nullptr", debug);
                    }
                }

                ///
                /// si necesitamos guardar nuestro script en un segmento
                ///
                else if (
                    (lines[Line_to_execute]).Trim() == "org"
                    )
                {
                    ///
                    /// guardar el script
                    ///
                    segments[int.Parse((lines[Line_to_execute + 1]).Trim())] = script;
                }

                ///
                /// si necesitamos importarlo desde otro script
                ///
                else if (
                        (lines[Line_to_execute]).Trim() == "org import"
                        )
                {
                    segments[int.Parse((lines[Line_to_execute + 2]).Trim())] = File.ReadAllText(Path.Join(globvars["@dircurrent"], LimaSyntax(lines[Line_to_execute + 1].Trim(), debug)));
                }
                ///
                /// condicionales if
                ///
                else if (
                    (lines[Line_to_execute]).Trim() == "if"
                    )
                {
                    ///Console.WriteLine("in if");
                    string if_condition;

                    ///
                    /// la condicion
                    ///
                    if_condition =
                        (lines[Line_to_execute + 1]).Trim() + /// (
                        (lines[Line_to_execute + 2]).Trim() + /// ...
                        (lines[Line_to_execute + 3]).Trim() + /// operator
                        (lines[Line_to_execute + 4]).Trim() + /// ...
                        (lines[Line_to_execute + 5]).Trim() /// )
                        ;

                    ///
                    /// ir al if
                    ///
                    Line_to_execute += 6;

                    ///Console.WriteLine(if_condition);

                    ///Console.WriteLine(LimaSyntax(if_condition, debug));

                    ///
                    /// si no es falso
                    ///
                    if (
                        LimaSyntax(if_condition, debug) != "false"
                        )
                    {
                        ///Console.WriteLine("xd");

                        ///
                        /// valores para recuperar
                        ///
                        string popcode = lscript;

                        Dictionary<int, int> ppopback = popback;

                        ///
                        /// el codigo a ejecutar
                        ///
                        string code = "";

                        int ele = 0;

                        ///
                        /// obtener el if
                        ///
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

                        ///
                        /// si es verdadera
                        ///
                        if (
                           LimaSyntax(if_condition, debug) == "true"
                            )
                        {
                            ///
                            /// recuperar codigo
                            ///
                            int popline = Line_to_execute;

                            popback.Clear();

                            Line_to_execute = 0;

                            ///
                            /// ejecutar if
                            ///
                            ExecuteLimaScript(code, debug);

                            ///
                            /// recuperar los valores
                            ///
                            Line_to_execute = popline;

                            popback = ppopback;
                        }
                    }

                    ///
                    /// si es falso
                    ///
                    else
                    {
                        ///Console.WriteLine("yo");
                        int ele = 0;

                        ///
                        /// saltarnos el if
                        ///
                        while (
                            true
                            )
                        {
                            ///Console.WriteLine(Line_to_execute);
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

                ///
                /// delcaracion de variable
                ///
                else if (
                    (lines[Line_to_execute]).Trim() == "var"
                    )
                {
                    ///
                    /// los valores
                    ///
                    string name = (lines[Line_to_execute + 1]).Trim();
                    string op = (lines[Line_to_execute + 2]).Trim();
                    string value = (lines[Line_to_execute + 3]).Trim();

                    ///
                    /// globalizarla?
                    ///
                    if (
                        (lines[Line_to_execute - 1]).Trim() == "[globalize]"
                        )
                    {
                        globvars[VariablesSyntax(name)] = Operate_With(
                            globvars.ContainsKey(VariablesSyntax(name)) ? globvars[VariablesSyntax(name)] : "",
                            op,
                            LimaSyntax(value, debug)
                            );
                    }

                    ///
                    /// no la globalizaste
                    ///
                    else
                    {
                        lima_variables[VariablesSyntax(name)] = Operate_With(
                            lima_variables.ContainsKey(VariablesSyntax(name)) ? lima_variables[VariablesSyntax(name)] : "",
                            op,
                            LimaSyntax(value, debug)
                            );
                    }
                }

                ///
                /// saltos
                ///
                else if (
                    (lines[Line_to_execute]).Trim() == "jump" ||
                    (lines[Line_to_execute]).Trim() == "jt" ||
                    (lines[Line_to_execute]).Trim() == "jf"

                    )
                {
                    ///
                    /// el buscador
                    ///
                    int section_search;

                    ///
                    /// buscar la seccion
                    ///
                    for (section_search = 0; section_search < lines.Length; section_search++)
                    {
                        ///
                        /// si encontro la palabra seccion
                        ///
                        if (
                            lines[section_search].Trim() == "section"
                            )
                        {
                            if (
                                lines[section_search + 1].Trim() == lines[Line_to_execute + 1].Trim()
                                )
                            {
                                ///Console.WriteLine(lines[section_search + 1].Trim());

                                ///
                                /// salto si es falso
                                ///
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

                                ///
                                /// si saltar si es verdadero
                                ///
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

                                ///
                                /// saltar de todos modos
                                ///
                                else
                                {
                                    popback.Add(popback.Count + 1, Line_to_execute + 1);
                                    Line_to_execute = section_search;
                                }
                            }
                        }
                    }
                }

                ///
                /// palabra popback
                ///
                else if (
                    lines[Line_to_execute] == "popback"
                    )
                {
                    ///
                    /// ver si la longitud no es 0
                    /// 
                    if (popback.Count != 0)
                    {
                        ///
                        /// regresar a la linea
                        ///
                        Line_to_execute = popback[popback.Count];
                        popback.Remove(popback.Count);
                    }

                    ///
                    /// si es cierto
                    ///
                    else
                    {
                        ///
                        /// volver a la primera linea
                        ///
                        Line_to_execute = 0;
                    }
                }

                ///
                /// terminar el programa
                ///
                else if (
                    lines[Line_to_execute] == "__endprog__"
                    )
                {
                    return;
                }

                ///
                /// ejecutar el comando si la entrada no es valida
                ///
                else
                {
                    Execute(lines[Line_to_execute].Trim(), debug);
                }

                ///
                /// siguiente linea
                ///
                Line_to_execute++;

            }
            return;
        }
    }

}

/// creditos
///
/// aqui aparecen los creditos de lima
/// contribuidores, escritores , managers, y creditos de ejemplo0s
/// 
/// escrito por:
///     Erick Antonio Nava Camarillo
///     
/// 
/// manejado por:
///     Erick Antonio Nava Camarillo
///     
/// 
/// contribuidores:
///     Skale -> esta haciendo su propio interprete de lima, OpenLima
///     la comunidad de lima ^-^
///    
/// 
/// ejemplos escritos por:
///     Erick Antonio Nava Camarillo
///     