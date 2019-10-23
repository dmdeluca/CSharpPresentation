using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPresentation
{
    public class Slide : IDisplayable
    {
        public string Text;
        public Title Title;
        public List<IDisplayable> Contents;

        public Slide()
        {
            Contents = new List<IDisplayable>() { };
        }

        public Slide SetTitle(string titleText)
        {
            Title = new Title(titleText);
            return this;
        }

        public Slide AddBullet(string text, byte level = 0)
        {
            Contents.Add(new BulletPoint(text, level));
            return this;
        }

        public void Display()
        {
            Title.Display();
            foreach (var content in Contents)
            {
                content.Display();
                Console.ReadKey();
            }
            Console.WriteLine("(end of slide)");
            Console.ReadKey();
        }
    }
}
