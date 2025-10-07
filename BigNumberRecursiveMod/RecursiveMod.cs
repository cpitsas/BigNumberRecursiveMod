using System;

namespace BigNumberRecursiveMod
{
    public class RecursiveMod
    {

        /// <summary>
        /// Recursively calculates the number modulo.
        /// </summary>
        /// <param name="numberSequence">A string character sequence representing an integer.</param>
        /// <param name="divider">Must represent an integer.</param>
        /// <returns>The modulo of the sequence % divider</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int CalculateMod(string numberSequence, string divider)
        {
            var divParse = int.TryParse(divider, out int dividerInt);

            if (!divParse)
            {
                throw new ArgumentException("Divider must be an integer.");
            }

            return CalculateRecursive(numberSequence, dividerInt);
        }

        /// <summary>
        /// Recursively calculates the number modulo.
        /// </summary>
        /// <param name="numberSequence">A string character sequence representing an integer.</param>
        /// <param name="divider">The divider number.</param>
        /// <returns>The modulo of the sequence % divider</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int CalculateMod(string numberSequence, int divider)
        {
            return CalculateRecursive(numberSequence, divider);
        }

        private static int CalculateRecursive(string numberSequence, int divider)
        {
            int result = 0;

            foreach (char c in numberSequence)
            {
                if (c < '0' || c > '9')
                    throw new ArgumentException("Invalid character in the number sequence. Only digits allowed.");

                int digit = c - '0';
                result = (result * 10 + digit) % divider;
            }

            return result;
        }
    }
}
