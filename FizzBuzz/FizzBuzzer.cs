using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    internal class FizzBuzzer
    {
        private int count;

        internal string SayNext()
        {
            this.count++;
            string say = GetSay(this.count);
            return string.Format(null, "{0} - {1}", this.count, say);
        }

        internal static string GetSay(int number)
        {
            bool ismod3 = ((number % 3) == 0);
            bool ismod5 = ((number % 5) == 0);

            if (ismod3 && ismod5)
                return "Fizz Buzz";
            // 3で割り切れるならばFizzを返す
            if (ismod3)
                return "Fizz";
            // 5で割り切れるならばBuzzを返す
            if (ismod5)
                return "Buzz";
            return number.ToString();
        }
    }
}
