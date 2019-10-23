using System;

namespace CSharpPresentation
{
    public class Title : IDisplayable
    {
        public string Text;
        public byte Level;

        public Title(string text, byte level = 0)
        {
            Text = text;
            Level = level;
        }

        public void Display()
        {
            string upperlinechar;
            string lowerlinechar;

            switch (Level)
            {
                case 0:
                    upperlinechar = "=";
                    lowerlinechar = "=";
                    break;
                case 1:
                    upperlinechar = " ";
                    lowerlinechar = "-";
                    break;
                default:
                    upperlinechar = " ";
                    lowerlinechar = " ";
                    break;
            }

            string upperline, lowerline;
            upperline = upperlinechar.Times(Text.Length);
            lowerline = lowerlinechar.Times(Text.Length);

            Console.WriteLine();
            if (!string.IsNullOrWhiteSpace(upperline))
                Console.WriteLine(upperline);
            Console.WriteLine(Text);
            if (!string.IsNullOrWhiteSpace(lowerline))
                Console.WriteLine(lowerline);

            Console.ReadKey();
        }
    }
}
