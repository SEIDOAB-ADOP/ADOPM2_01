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

			private int _age;
			public int Age { get { return _age; }
				set
				{
					if (value <= 0 || value > 100)
						throw new  ArgumentException("Wrong Age");

                    _age = value;
				}
			}

			public void GetAnimalFood()
			{
				//Massive to code to connect to a database and gett the best food
				throw new Exception("Database no acessible");
			}

			public override string ToString() => $"{Name} the {AnimalMood} {AnimalKind}. {Age} years old";
			public csAnimal()
			{
				AnimalMood = enAnimalMood.PissedOff;
				AnimalKind = enAnimalKind.Lion;
            }
         }


		static void Main(string[] args)
		{

            //var an1 = new csAnimal();
            var an1 = new csAnimal() { Name = "Joe", AnimalMood = enAnimalMood.Hungry, AnimalKind = enAnimalKind.Tiger };

			try
			{
				an1.Age = 5;
				//an1.GetAnimalFood();

				Console.WriteLine(an1);


				Console.WriteLine("Program terminated!");
			}
			catch(ArgumentException e)
			{
				Console.WriteLine("Not so good buddy!");
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
			{
                Console.WriteLine("My json file is closed");
            }

			Console.ReadKey();

        }
	}
}
//Excercises:
//1.	Can SharesOwned be initialized through object initialization, i.e. new Stock { SharesOwned = 100 };?

//2.	Make public (should it be static?) readonly members to return nr of Stocks objects created.
//		Create a few Stocks using object initialization, and write out number of Stock instances created

//3.	Modify code to write the Worth of the instance of Stock with the highest worth created. 

