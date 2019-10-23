namespace CSharpPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var pt = new Presentation();

            pt.AddSlide().SetTitle("What is C#, and why is it amazing?")
                .AddHeading("By David DeLuca");

            pt.AddSlide().SetTitle("What is C#?")
                .AddBullet("talk about .NET")
                .AddBullet("memory management")
                .AddBullet("built-in exception handling")
                .AddBullet("powerful and easy to use");

            pt.AddSlide().SetTitle("What is so great about C#?")
                .AddBullet("It does its own garbage collection")
                .AddBullet("It handles its own exceptions")
                .AddBullet("It is a pure object oriented language")
                .AddBullet("(Everything is an object)", 2)
                .AddBullet("It's in demand ($72k globally -> $90k US)")
                .AddBullet("DANGEOUSLY easy to learn");

            pt.AddSlide().SetTitle("Cool things you can do with C#")
                .AddBullet("Generics")
                .AddBullet("Interfaces")
                .AddBullet("LINQ")
                .AddBullet("Extension methods")
                .AddBullet("Reflection")
                .AddBullet("Async/await")
                .AddBullet("Nullable types");

            pt.AddSlide().SetTitle("My favorite libraries")
                .AddBullet("LINQ")
                .AddBullet("Autofac")
                .AddBullet("Moq");

            pt.AddSlide().SetTitle("Why would you use C#?")
                .AddBullet("apps for windows")
                .AddBullet("writing games in Unity")
                .AddBullet("creating a website");

            pt.AddSlide().SetTitle("Why would you NOT use C#?")
                .AddBullet("if you want to build a tiny, lightning-fast program")
                .AddBullet("if you want to code from the cmd line")
                .AddBullet("if you are looking for the absolute fastest fastness");

            pt.AddSlide().SetTitle("What out there in the world is written with C#?")
                .AddBullet("Pretty much every WINDOWS app")
                .AddBullet("Games in UNITY")
                .AddBullet("StackOverflow (ASP.NET Core)")
                .AddBullet("Good old MS Visual Studio")
                .AddBullet("This presentation!");

            pt.AddSlide().SetTitle("Q&A");

            pt.Show();
        }
    }
}
