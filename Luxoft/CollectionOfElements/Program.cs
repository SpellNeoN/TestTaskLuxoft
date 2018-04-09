using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace CollectionOfElements
{

    //This class representing element with fields num, name and age
    class Element
    {
        public int num;
        public String name;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            //Create collection with test data
            Collection<Element> testCollection = new Collection<Element>
            {
				//Add elements into collection
				new Element { num = 1, age = 19, name = "first" },
                new Element { num = 1, age = 21, name = "second" }, //Should be added to output collection
                new Element { num = 2, age = 20, name = "third" },
                new Element { num = 2, age = 21, name = "forth" }, //Should be added to output collection
                new Element { num = 3, age = 19, name = "fifth" },
                new Element { num = 3, age = 21, name = "sixth" }, //Should be added to output collection
                new Element { num = 3, age = 22, name = "seventh" }
            };

            //Invoke test method with collection as an argument and show result in console
            program.TestMethod(testCollection);
            Console.ReadKey();

        }

        //Test method implementation
        Collection<Element> TestMethod(Collection<Element> elements)
        {
            Collection<Element> result = new Collection<Element>();

            int count = elements.Count();
            int ageMax = 20;

            //Filter all elements which has attribune age > 20
            for (int i = 0; i < count; i++)
            {
                if (elements[i].age > ageMax)
                {
                    result.Add(elements[i]);
                }
            }

            //Make output collection unique by attribute "num"
            for (int i = 0; i < result.Count; i++)
            {
                for (int k = 1; k < result.Count; k++)
                {
                    //If element not unique by attribute num - remove it from result collection
                    if (result[i].num == result[k].num && i != k) result.Remove(result[k]);
                }
            }

            //According to requirements and test data (test collection) we should receive 3 elements
            Console.WriteLine("Expected count of elements in collection with test data: 3.");
            Console.WriteLine("Actual Result: " + result.Count() + " elements.");

            return result;
        }
    }
}