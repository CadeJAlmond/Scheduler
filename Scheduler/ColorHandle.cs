using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    // Author : Cade Almond
    // Date   : 8/8/2022
    //
    // Class Contents 
    // This class is responsible for generating colors for the Events to
    // display while presented on the Calendar form. These Colors are
    // generated using two strategies, one is selecting a random color,
    // and the other using color theory to select the best color in comparison
    // to the most previous chosen color.
    public static class ColorHandle
    {
       // Variable for random Color selection
       static private Random Ran = new Random();

       // Data structures for Color hex codes access
       private static Dictionary<string, string[]> Colors;
      
       // The Colors used in creating Events
       static string[] Blues = {"#06b6d4", "#0ea5e9", "#0284c", 
            "#60a5fa","#22d3ee"};
        static string[] Reds = { "#f87171", "#ef4444", "#dc2626",
            "#bd3d43", "#d74545", "#e11d48"};
        static string[] Greens  = {"0d9488", "#10b981", "#22c55e",
            "#4ade80" };
        static string[] Oranges = {"#ea580c", "#f97316", "#fb923c",
            "#f59e0b"};
        static string[] Yellows = { "#fde047", "#facc15", "#eab308" };

        // Setup the Data structures accordingly. All colors
        // returned from this class will have this format
        // First Letter of Choosen Color : Hex Value
        // Ex. Rf87171, B06b6d4, Yfacc15, G10b981
        static ColorHandle() 
        {
            Colors = new Dictionary<string, string[]>();
            Colors.Add("Blue",Blues);
            Colors.Add("Red",Reds);
            Colors.Add("Yellow", Yellows);
            Colors.Add("Orange", Oranges);
            Colors.Add("Green", Greens);
        }

        /// <summary>
        /// This method will return a randomly selected Color
        /// </summary>
        /// <returns></returns>
        public static string FirstColorSelector() 
        { 
           string[] AllColors   = Colors.Keys.ToArray();  
           int      ColorChoose = Ran.Next(0 ,AllColors.Length);
           string   ColorType   = AllColors[ColorChoose];
           string[] ColorValues = Colors[ColorType];
           int ValueIndex       = Ran.Next(0, ColorValues.Length);
           return $"{ColorType.Substring(0, 1)}{ColorValues[ValueIndex]}"; 
        }

        /// <summary>
        /// This method will generate a new color, with a 
        /// 50% possibility of returning the best color relates to
        /// the color last used for the last event create. Or it will
        /// just choose a random Color.
        /// </summary>
        /// <param name="DateOfMonth"></param>
        /// <returns></returns>
        public static string GetNextColor(string DateOfMonth) 
        {
            int ColorSelection = Ran.Next(1,2);
            if (ColorSelection % 2 == 0)
            {
                _Event LastEvent = SQLHandle.GetLastEventInMonth(DateOfMonth);
                string PreviousColor = LastEvent.Color;
                return OptimizeNextColor(PreviousColor.Substring(0, 1));
            }
            else
                return FirstColorSelector();
        }

        /// <summary>
        /// This method will determine the best color to use, given
        /// the last color that was used in creating an event within
        /// a given month. Colors are selected using Color Theory. 
        /// </summary>
        /// <param name="LastColor"></param>
        /// <returns></returns>
        private static string OptimizeNextColor(string LastColor) 
        {
            if (LastColor == "R")
                return $"G{Greens[Ran.Next(Greens.Length)]}";
            if (LastColor == "G")
                return $"R{Reds[Ran.Next(Reds.Length)]}";
            if (LastColor == "O")
                return $"B{Blues[Ran.Next( Blues.Length)]}";
            if (LastColor == "B")
                return $"O{Oranges[Ran.Next( Oranges.Length)]}";
            // last one should be purple
            if (LastColor == "Y")
                return $"B{Blues[Ran.Next( Blues.Length)]}";
            return $"Y{Yellows[Ran.Next(  Yellows.Length)]}";
        }
    }
}
