using System;

namespace ADOPM2_01_12a
{
    class Program
    {
        public class csBank
        {
            private readonly int[] AccountBalances = { 1000, 20000, 35, 4 };

            public string Name { get; set; } = "SEB";

            public int this[int i] => AccountBalances[i];
  
        }


        /*
		class ProtectedArray
		{
			private int[] myArray = { 1, 2, 3, 4, 5 };

            public int this[int idx] => myArray[idx];
        }

        class UnProtectedArray
        {
            public int[] myArray = { 1, 2, 3, 4, 5 };
        }
        */
		static void Main(string[] args)
        {

            var b = new csBank();
            Console.WriteLine(b.Name);

            //b.AccountBalances[0] = 100000;
            //Console.WriteLine(b.AccountBalances[0]);

            /*
            var upa = new UnProtectedArray();
            var pa = new ProtectedArray();

            Console.WriteLine(upa.myArray[0]); //Will cause error

            //Console.WriteLine(pa.myArray[0]); //Will cause error
            Console.WriteLine(pa[0]);
            */
        }
    }
}
//Excercises:
//1.	In Main try to modify the content of myArray in upa and in pa.
//2.    In Main print out the length of myArray in upa and pa. How would you do it?