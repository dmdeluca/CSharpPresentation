namespace CSharpPresentation
{
    internal class Heading : IDisplayable
    {
        private readonly string _text;

        public Heading(string text)
        {
            this._text = text;
        }

        public void Display()
        {
            System.Console.WriteLine("-".Times(3) + _text + "-".Times(3));
        }
    }
}