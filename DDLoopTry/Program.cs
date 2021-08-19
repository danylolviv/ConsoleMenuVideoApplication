using System;

namespace DDLoopTry
{
    class Program
    {
        static void Main(string[] args)
        {
            bool one = true;
            bool two = true;
            
            int selectionLevel1 = 0;

            while (selectionLevel1 == 0)
            {
                switch (selectionLevel1)
                {
                    
                }
                Pr("1. Main");
                Pr("2. Movies");
                Pr("3. Delete");
                Pr("4. Edit");
                Pr("5. Remove");
                selectionLevel1 = Int32.Parse(Console.ReadLine());
            }
        }

        private static void Pr(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}