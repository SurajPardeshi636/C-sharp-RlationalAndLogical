using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_RlationalAndLogical
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;

            bool ival = i == j;
            Console.WriteLine("Equal to operator==:"+ival); // in this line is bothe are same value thats why it ivenit answer in boolean true or false because i and j value both are same

            bool ivalue = i != j;
            Console.WriteLine("is not equal to operator !=:"+ivalue);

            bool greter = i >= j;
            Console.WriteLine(greter);

            bool Agreter = i > j;
            Console.WriteLine(Agreter);


            bool S_greter = i <= j;
            Console.WriteLine(S_greter);

            bool SS_greter = i < j;
            Console.WriteLine(SS_greter);

            // & bitwise and
            // && logical and
            //  | bitwise or
            //  || logical and
            //   ! bitwie NOT
            //   ^  Bitwise XOR
            // the all are the above operators


            int x =1;
            int y =1;

            // this is the first type
            bool res = x > 1 && x < 0;
            Console.WriteLine("Logical and"+res);


            // this is thesecond type usin if else condition
            if( x > 1 && x < 0)
            {
                Console.WriteLine("Logical and is true......");
            }
            else
            {
                Console.WriteLine("Logical and false......" );
            }


            //ternary operator 

            string str = "";
            int z = 1;
            str = z > 1 ? "t is greater than 1" : "it is less than 1";
            Console.WriteLine(str);


            string strl = "";
            int v = 1;
            int val = v > 1 ? 1 : 0;
            Console.WriteLine(val);







            Console.ReadLine();

                  }
    }
}
