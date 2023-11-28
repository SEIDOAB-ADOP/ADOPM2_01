using System;
namespace ADOPM2_01_06
{
	class Program
	{
		public enum enAnimalKind { Elephant, Tiger, Lion }
        public enum enAnimalMood { Sleepy, Hungry, PissedOff }
        public class csAnimal
		{
			public enAnimalKind AnimalKind { get;  set; }

			public enAnimalMood AnimalMood { get; set; }
			public string Name { get; set; }

			public void ChangeAnimal(enAnimalKind animalKind)
			{
				AnimalKind = animalKind;
			}

			public override string ToString() => $"{Name} the {AnimalMood} {AnimalKind}";
			public csAnimal()
			{
				AnimalMood = enAnimalMood.PissedOff;
				AnimalKind = enAnimalKind.Lion;
            }
         }

		static void Main(string[] args)
		{
            //var an1 = new csAnimal();
            var an1 = new csAnimal() { Name = "Joe", AnimalMood = enAnimalMood.Hungry};
			Console.WriteLine(an1);

			an1.AnimalKind = enAnimalKind.Tiger;
			an1.AnimalMood = enAnimalMood.Sleepy;
			Console.WriteLine(an1);
        }
	}
}
//Excercises:
//1.	Can SharesOwned be initialized through object initialization, i.e. new Stock { SharesOwned = 100 };?

//2.	Make public (should it be static?) readonly members to return nr of Stocks objects created.
//		Create a few Stocks using object initialization, and write out number of Stock instances created

//3.	Modify code to write the Worth of the instance of Stock with the highest worth created. 

