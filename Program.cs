
using Generics_Problem;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Generics in C#----");

            // Generic Class Demo

            // bool equal = Generics_Class<int>.AreEqual(2, 2);
            // bool equal = Generics_Class<string>.AreEqual("Vedant", "vedant");
            bool equal = Generics_Class<float>.AreEqual(3.5f, 5.6f);

            if (equal)
            {
                Console.WriteLine("Both Equal.");
            }
            else
            {
                Console.WriteLine("Not Equal.");
            }

            Generics_Class<int> generics = new Generics_Class<int>();

            int result = generics.CompareAll(1, 2, 3);

            Console.WriteLine("The largest is " + result);


        }
    }
}
