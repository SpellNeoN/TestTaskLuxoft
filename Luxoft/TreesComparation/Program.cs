using System;

namespace TreesComparation
{
    
    //Binary Tree Node has value and pointers to left and right child
    class BTN
    {
        public int val;
        public BTN left;
        public BTN right;

        public BTN(int a)
        {
            this.val = a;
        }
    }

    class Program
    {
        BTN root1;
        BTN root2;

        //Test method implementation
        static bool IsIdentical(BTN a, BTN b)
        {
            //When two nodes empty they are treated as identical -> true
            if (a == null && b == null) return true;

            //When both nodes not null - check identity
            else if (a != null && b != null)
                return (a.val == b.val &&
                        IsIdentical(a.left, b.left) &&
                        IsIdentical(a.right, b.right));

            //When one node is empty and second is not -> false
            else return false;
        }

        static void Main(string[] args)
        {
            //Choose an option for creating and populating trees
            Console.WriteLine("For comparing two binary trees choose method of population");
            Console.WriteLine("Press 1: For two fully equal trees;");
            Console.WriteLine("Press 2: For two different trees;");
            Console.WriteLine("Press 3: For randomly populated trees;");

            ConsoleKeyInfo option = Console.ReadKey();

            Program program = new Program();

            switch (option.KeyChar)
            {
                //Will be populated with the same structure and values
                case (char)ConsoleKey.D1:
                    program.root1 = new BTN(1);
                    program.root1.left = new BTN(1);
                    program.root1.right = new BTN(1);
                    program.root1.left.left = new BTN(1);
                    program.root1.left.right = new BTN(1);

                    program.root2 = new BTN(1);
                    program.root2.left = new BTN(1);
                    program.root2.right = new BTN(1);
                    program.root2.left.left = new BTN(1);
                    program.root2.left.right = new BTN(1);
                    break;

                    //Will be populated with different structure and values
                case (char)ConsoleKey.D2:
                    program.root1 = new BTN(1);
                    program.root1.left = new BTN(1);
                    program.root1.right = new BTN(1);
                    program.root1.left.left = new BTN(1);
                    program.root1.left.right = new BTN(1);

                    program.root2 = new BTN(2);
                    program.root2.left = new BTN(2);
                    program.root2.right = new BTN(2);
                    program.root2.left.left = new BTN(2);
                    program.root2.left.right = new BTN(2);
                    program.root2.left.left.left = new BTN(2); //additional leaf of tree
                    break;

                case (char)ConsoleKey.D3:
                    Random rnd1 = new Random();

                    //root2 will be randomly populated with values 1 or 2. (50% for equal and 50% for not equal chance)
                    program.root1 = new BTN(rnd1.Next(1, 2));
                    program.root1.left = new BTN(rnd1.Next(1, 2));
                    program.root1.right = new BTN(rnd1.Next(1, 2));
                    program.root1.left.left = new BTN(rnd1.Next(1, 2));
                    program.root1.left.right = new BTN(rnd1.Next(1, 2));

                    program.root2 = new BTN(rnd1.Next(1, 3));
                    program.root2.left = new BTN(rnd1.Next(1, 2));
                    program.root2.right = new BTN(rnd1.Next(1, 2));
                    program.root2.left.left = new BTN(rnd1.Next(1, 2));
                    program.root2.left.right = new BTN(rnd1.Next(1, 2));
                    break;

                default:
                    //When choosen option not 1, 2 or 3 - show notification and close an application
                    Console.WriteLine("\r\nIncorrect option. Application will be closed.");
                    Environment.Exit(0);
                    break;
            }

            //Notify a user about choosen option
            Console.WriteLine("\r\nOption #{0} is selected, binary tree populated", option.KeyChar);

            //And run the test method for trees comparation
            if (IsIdentical(program.root1, program.root2))
            {
                Console.WriteLine("Trees fully equal");
            }
            else 
            {
                Console.WriteLine("Trees not equal");
            }
                
            Console.ReadKey();
        }
    }
}
