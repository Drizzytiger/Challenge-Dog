using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DOG___
{
    enum Gender
    {
        Male,
        Female
    }
    public class Dog
    {
        public string Name, Owner;
        public int age;
        public Type gender;
        private string v1;
        private string v2;
        private int v3;
        private Gender sex;

        public dog(string v1, string v2, int v3, Gender sex)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.sex = sex;
        }

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

        string Bark(int num)
        {
            string bark = "WOOF!!";
            Console.WriteLine("How many times should I bark at thee?");
            Console.ReadLine();
            for (int x = 0; x <= num; x++)
            {
                Console.WriteLine("{0)", bark);
            }
            return bark;
         }

         public int GetTag()
         {
            Console.WriteLine("If lost please return to {0}",Owner);
            if(gender = 0)
            {
                Console.WriteLine("His name is {0}",Name);
            }
            if(Gender = 1)
            {
                Console.WriteLine("Her name is {0}", Name);
            }
            return 0;
         }

        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.
        }
    }
}

