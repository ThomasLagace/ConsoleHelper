using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelper
{
    internal class StringConsolePartClass
    {
        public ConsoleColor ?forgroundColor;
        public ConsoleColor ?backgroundColor;
        public string textPart;

        readonly Dictionary<string, ConsoleColor> StringConsoleColor = new Dictionary<string, ConsoleColor>
        {
            { "black", ConsoleColor.Black },
            { "0", ConsoleColor.Black },
            { "white", ConsoleColor.White },
            { "w", ConsoleColor.White },

            { "gray", ConsoleColor.Gray },
            { "gy", ConsoleColor.Gray },
            { "darkgray", ConsoleColor.DarkGray },
            { "dgy", ConsoleColor.DarkGray },

            { "red", ConsoleColor.Red },
            { "r", ConsoleColor.Red },
            { "darkred", ConsoleColor.DarkRed },
            { "dr", ConsoleColor.DarkRed },

            { "green", ConsoleColor.Green },
            { "gn", ConsoleColor.Green },
            { "darkgreen", ConsoleColor.DarkGreen },
            { "dgn", ConsoleColor.DarkGreen },

            { "blue", ConsoleColor.Blue },
            { "b", ConsoleColor.Blue },
            { "darkblue", ConsoleColor.DarkBlue },
            { "db", ConsoleColor.DarkBlue },

            { "yellow", ConsoleColor.Yellow },
            { "y", ConsoleColor.Yellow },
            { "darkyellow", ConsoleColor.DarkYellow },
            { "dy", ConsoleColor.DarkYellow },

            { "cyan", ConsoleColor.Cyan },
            { "c", ConsoleColor.Cyan },
            { "darkcyan", ConsoleColor.DarkCyan },
            { "dc", ConsoleColor.DarkCyan },

            { "magenta", ConsoleColor.Magenta },
            { "m", ConsoleColor.Magenta },
            { "darkmagenta", ConsoleColor.DarkMagenta },
            { "dm", ConsoleColor.DarkMagenta },
        };

        StringConsolePartClass(string textPart, string forgroundColor = null, string backgroundColor = null)
        {
            this.textPart = textPart;
            this.forgroundColor = StringConsoleColor.TryGetValue(forgroundColor, out ConsoleColor forgoundColor) ? forgoundColor : null;
            this.backgroundColor = StringConsoleColor.TryGetValue(forgroundColor, out ConsoleColor backgrondColor) ? backgrondColor : null;
        }
    }
}
