namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Start
    {
        
        static void Main()
        {
            //string text = Console.ReadLine();
            //StringBuilder sb = new StringBuilder();

            //foreach (char c in text)
            //{
            //    sb.Append(string.Format(@"\u{0:x4}", (int)c));
            //}

            //Console.WriteLine(sb.ToString());

            // Completely untested
            // String to Unicode code points
            StringBuilder sb = new StringBuilder();

            string text = Console.ReadLine();
            int highbits = 0;
            foreach (char ch in text)
            {               
                int i = (int)ch;
                
                if (i < 0xD800 || i > 0xDFFF)
                {
                    sb.Append(string.Format(@"\u{0:x4}", i));
                }                                
                
                else // ... Surrogate low
                {
                    sb.Append(string.Format(@"\u{0:x6}", highbits << 10 + (i - 0xDC00) + 0x10000));
                }                                        
            }

            Console.WriteLine(sb.ToString());       
        }
    }
}
