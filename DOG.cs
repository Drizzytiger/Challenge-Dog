using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dog
{
    enum Gender
    {
        Male,
        Female
    }
    public class Dog
    {
        public string Name, Owner;
        public int Age;
        public Type gender;
        static void PrintGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    Console.WriteLine("Male");
                    break;
                case Gender.Female:
                    Console.WriteLine("Female");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
        internal string Bark(int num)
        {
            string bark = "WOOF!!";
            Console.WriteLine("How many times should I bark at thee?");
            Console.ReadLine();
            for (int x = 0; x <= num; x++)
            {
                Console.WriteLine("{0}", bark);
            }
            return bark;
        }

        public int GetTag()
         {
            Console.WriteLine("If lost please return to {0}",Owner);
            /*if(0 = Gender.Male)
            {
                Console.WriteLine("His name is {0}",Name);
            }
            if(Gender.Male = 1)
            {
                Console.WriteLine("Her name is {0}", Name);
            }*/
            return 0;

         }

        internal Dog(string name,string owner, int age, Gender sex)
        {
            name = Name;
            owner = Owner;
            age = Age;
        }

    }
     public class Program
    {
  
        static void Main()
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.
            Console.ReadKey();
        }

    }
}

