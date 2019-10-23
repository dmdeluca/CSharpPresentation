using System;

namespace CSharpPresentation
{
    public class BulletPoint : IDisplayable
    {
        public string Text;
        public byte IndentLevel;

        public BulletPoint(string text, byte indentLevel)
        {
            Text = text;
            IndentLevel = indentLevel;
        }

        public void Display()
        {
            Console.WriteLine("  ".Times(IndentLevel) + "* " + Text);
        }
    }
}
