using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimaInterpreter
{
    class graphichsMode
    {
        public int videoMode = 0;

        public void 
            SetToGraphicalMode
            (
            )
        {
            if (videoMode == 0)
            {
                Console.SetBufferSize(800, 600 * 2);
                Console.SetWindowPosition( 0, 0 );
                Console.SetWindowSize(800, 600 * 2);

                videoMode = 1;
            }
        }

        public void
            BltGop
            (
            int x,
            int y,
            int sizex,
            int sizey,
            ConsoleColor Color
            )
        {
            SetToGraphicalMode
(
);
            ConsoleColor pop_color = Console.BackgroundColor;
            for (int i = 0; i < sizey; i++)
            {
                for (int j = 0; j < sizex * 2; j++)
                {
                    Console.SetCursorPosition(x + j, y + i);

                    Console.BackgroundColor = Color;
                    Console.Write(" ");

                    Task.Delay(1);
                }
            }
            Console.BackgroundColor = pop_color;
        }
    }
}
