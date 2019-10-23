using System;
using System.Collections.Generic;

namespace CSharpPresentation
{
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
                Console.Clear();
                slide.Display();
            }

            Console.WriteLine("\n\n-- WHOOPS. THAT IS THE END. --");
        }
    }
}
