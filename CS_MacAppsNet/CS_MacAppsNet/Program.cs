using System;

namespace CS_MacAppsNet
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("DEMO REF and OUT");

            int a = 10, b = 20;
             

            int? c = null; // Nullable Type (CLR have not allocated it)

            Console.WriteLine($"Before XChange a = {a} and  b = {b}");

            XChange(a,b);

            Console.WriteLine($"After XChange a = {a} and  b = {b}");

            XChangeUsingRefs(ref a, ref b);

            Console.WriteLine($"After XChange a = {a} and  b = {b}");

            string str = "The Ref and Out is the Real Power of C# for Pass by Value";

            string subString;
            // The CLR will now allocate the space for subString based on
            // the out value generated from the Method call
            TryGetSubstring(str, out subString);
            Console.WriteLine($"Substring = {subString}");

            Console.ReadLine();
        }

        static void XChange(int x,int y)
        {
            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"In XChange Method x = {x} and  y = {y}");
        }
        /// <summary>
        /// To return More than one values from Method 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void XChangeUsingRefs(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"In XChangeRef Method x = {x} and  y = {y}");
        }
        /// <summary>
        /// Use out when the result is unpredicatble
        /// </summary>
        /// <param name="str"></param>
        /// <param name="substr"></param>
        static void TryGetSubstring(string str, out string substr)
        {
            if (str.Length > 0)
            {
                substr = str.Substring(2, 5);
            }
            else
            {
                substr = string.Empty;
            }
        }
    }
}

