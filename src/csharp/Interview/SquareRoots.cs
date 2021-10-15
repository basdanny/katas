namespace Interview
{
    class SquareRoots
    {
        /// <summary>
        /// get concatanation of all square roots of digits of a number
        /// </summary>        
        public static int GetDigitsSquareRoots(int n)
        {
            if (n / 10 == 0)
                return n * n;

            int lastdigit = n % 10;
            int lastdigitSquare = lastdigit * lastdigit;
            int multiplier = (lastdigitSquare > 9) ? 100 : 10;
            return lastdigitSquare + (GetDigitsSquareRoots(n / 10) * multiplier);
        }

        public static int GetDigitsSquareRoots2(int n)
        {
            var number = n;
            var result = 0;
            var multiplier = 1;
            while(number != 0) {
                var digit = number % 10;
                var digitSquare = digit * digit;

                result += digitSquare * multiplier;
                multiplier *= ((digitSquare > 9) ? 100 : 10); 

                number = number / 10;
            }

            return result;

        }

    }
}
