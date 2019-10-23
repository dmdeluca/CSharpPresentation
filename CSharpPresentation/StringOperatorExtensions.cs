using System.Linq;

namespace CSharpPresentation
{
    public static class StringOperatorExtensions
    {
        public static string Times(this string a, int b)
        {
            return b < 1 ? string.Empty : string.Join("", Enumerable.Repeat(a, b));
        }
    }
}
