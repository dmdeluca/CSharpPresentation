using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPresentation
{
    public class BulletPoint : IDisplayable
    {
        public string Text;
        public byte IndentLevel;

        public BulletPoint(string text, byte indentLevel = 0)
        {
            Text = text;
            IndentLevel = indentLevel;
        }

        public void Display()
        {
            Console.WriteLine("  ".Times(IndentLevel) + "* " + Text);
        }
    }

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

    public interface IDisplayable
    {
        void Display();
    }

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

        public Slide AddBullet(string text)
        {
            Contents.Add(new BulletPoint(text));
            return this;
        }

        public Presentation AddToPresentation(Presentation presentation)
        {
            presentation.AddSlide(this);
            return presentation;
        }

        public void Display()
        {
            Console.Clear();
            Title.Display();
            foreach (var content in Contents)
            {
                content.Display();
                Console.ReadKey();
            }
        }
    }

    public class Presentation
    {
        public List<Slide> Slides;

        public Presentation()
        {
            Slides = new List<Slide>() { };
        }

        public void AddSlide(Slide slide)
        {
            Slides.Add(slide);
        }

        public Slide AddSlide()
        {
            var slide = new Slide();
            Slides.Add(slide);
            return slide;
        }

        public void Show()
        {
            foreach (var slide in Slides)
            {
                slide.Display();
            }

            Console.WriteLine("\n\n-- WHOOPS. THAT IS THE END. --");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var pt = new Presentation();

            pt.AddSlide().SetTitle("What is C#, and why is it amazing?")
                .AddBullet("By David DeLuca");

            pt.AddSlide().SetTitle("What is C#?")
                .AddBullet("talk about .NET")
                .AddBullet("memory management")
                .AddBullet("powerful and easy to use");

            pt.AddSlide().SetTitle("Why would you use C#?")
                .AddBullet("apps for windows")
                .AddBullet("writing games in Unity")
                .AddBullet("creating a website");

            pt.Show();
        }

        private static void PrintHeading(string heading, int level = 0)
        {
        }
    }

    public static class StringOperatorExtensions
    {
        public static string Times(this string a, int b)
        {
            return b < 1 ? string.Empty : string.Join("", Enumerable.Repeat(a, b));
        }
    }
}
