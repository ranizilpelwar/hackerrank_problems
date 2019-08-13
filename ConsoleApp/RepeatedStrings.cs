using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public static class RepeatedStrings
    {
        public static long RepeatedString(string s, long n)
        {
            var occurrencesOfA = s.Count(x => x == 'a');
            if (occurrencesOfA == 0) return 0;
            var repetitions = n / s.Length;
            var total = occurrencesOfA * repetitions;
            var remainder = (int)(n % s.Length);
            var substring = s.Substring(0, remainder);
            var additionalAs = substring.Count(x => x == 'a');
            total += additionalAs;
            return total;
        }
    }
}
