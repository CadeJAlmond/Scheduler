using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public static class ColorHandle
    {
        private static Dictionary<string, string[]> Colors;
       static private Random Ran = new Random();
        // These should probably be hash sets
       static string[] Blues = {"#06b6d4", "#0ea5e9", "#0284c", 
            "#60a5fa","#22d3ee"};
        static string[] Oranges = {"#ea580c", "#f97316", "#fb923c",
            "#f59e0b"};
        static string[] Reds = { "#f87171", "#ef4444", "#dc2626",
            "#bd3d43", "#d74545", "#e11d48"};
        static string[] Yellows = { "#fde047", "#facc15", "#eab308" };
       static string[] Green = {"0d9488", "#10b981", "#22c55e", 
            "#4ade80" };

        static ColorHandle() 
        {
            Colors = new Dictionary<string, string[]>();
            Colors.Add("Blue",Blues);
            Colors.Add("Red",Reds);
            Colors.Add("Yellow", Yellows);
            Colors.Add("Green", Green);
        }

        // NEED TO TEST IF .Length works or if we need .Length - 1
        public static string FirstColorSelector() 
        { 
           string[] AllColors   = Colors.Keys.ToArray();  
           int      ColorChoose = Ran.Next(0 ,AllColors.Length);
           string   ColorType   = AllColors[ColorChoose];
           string[] ColorValues = Colors[ColorType];
           int ValueIndex       = Ran.Next(0, ColorValues.Length);
           return ColorValues[ValueIndex]; 
        }

        private static string GetNextColor(string LastColor) 
        {
            if (LastColor == "Red")
                return "green";
            if (LastColor == "green")
                return "red";
            if (LastColor == "orange")
                return "blue";
            if (LastColor == "blue")
                return "orange";
            if (LastColor == "Yellow")
                return "purple";
            return "yellow";
        }
    }
}
