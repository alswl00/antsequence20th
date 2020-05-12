using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "1", s2;
            char ch;
            int cnt = 0;
            for(int i=0; i < 19; i++)
            {
                cnt = 0;
                ch = s1[0];
                s2 = "";
                Console.WriteLine(s1);
                for(int j = 0; j < s1.Length; j++)
                {
                    if(ch != s1[j])
                    {
                        s2 = s2 +ch + cnt;
                        //Console.WriteLine("@" + s2);
                        cnt = 0;
                        ch = s1[j];
                        cnt++;
                    }
                    else
                    {
                        cnt++;
                    }
                    if (j + 1 == s1.Length)
                    {
                        s2 = s2 + ch + cnt;
                        //Console.WriteLine("**" + s2);
                    }

                }
                s1 = s2;
            }
           
            Console.WriteLine("\n20번째 숫자: "+s1);
        }
    }
}
