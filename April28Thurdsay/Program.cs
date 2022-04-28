using System;
using System.Collections;
using System.Linq;

namespace April28Thurdsay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] evennum = { 2, 4, 6};
            int[] oddnum = { 1, 7, 3, 4, 4, 2, 3, 5, 7, 9, 11, 13, 15 };
            int[] evenoddnum = { 10, 30, 89, 46 };
            var i = evennum.Length;

            var addi = evennum.Union(oddnum).Sum(x=>x);
            
            
                Console.WriteLine(addi);
            
            var num2 = evennum.Where(x => x % 2 == 0);
            foreach (int num in num2)
            {
                Console.WriteLine(num);
            }
            var num3 = evennum.Where(x => x > 10).OrderBy(x => x);
            foreach (int num in num3)
            {
                Console.WriteLine(num);
            }

            //var add2 = add2.Union(evenoddnum);
            //foreach (int num in add2)
            //{
            //    Console.WriteLine(num);
           
            //}
            //Console.WriteLine("%%%%%%%%%%%%%55");

            //// intersect
            //var j = evennum.Intersect(oddnum);
               
            //foreach (int num in j)
            //{
            //    Console.WriteLine(num);
            //}
            //// except
            //var excpect = oddnum.Except(evennum);
            //foreach(var num in excpect)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("22222222222222222222222");
            //// district
            //var district = evennum.Distinct().ToList();
            //foreach (int num in district)
            //{
            //    Console.WriteLine(  num);
            //}
            //Console.WriteLine("DDDDDDDDDDDDDDDDDDDDD");
            ////Aggegrate Oparator
            //var numbers = evennum.Where(x => x > 20).Sum(x => x);
            //Console.WriteLine(numbers);

            var ave =evennum.Average(x=>x);
            Console.WriteLine(ave);
            var  min = evennum.Min(x=>x);
            Console.WriteLine(min);
            var max = evennum.Max(x=>x);
            Console.WriteLine(max);

            //Aggregate  method 

            var allsum = evennum.Aggregate((a, b) => a +b);
            Console.WriteLine(allsum);






        }
    }
}
