using System;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SQL queries for test task:");
            /*
             *           We do have 2 tables in a relational database: 
             *          ∙ Clients (client_id(PK), client_name) 
             *          ∙ Orders (order_id(PK), client_id, order_sum, order_date) 
             *          Please write the following SQL queries: 
             *          a- list of clients, which have an order with order_sum > 50 
             *          b- clients, whose total sum of orders exceeds 100 
             */

            Console.WriteLine("A- list of clients, which have an order with order_sum > 50 ");
            Console.WriteLine("A: SELECT Clients.client_id, Clients.client_name FROM Clients INNER JOIN Orders ON Orders.client_id = Clients.client_id WHERE Orders.order_sum > 50;");
            Console.WriteLine("B- clients, whose total sum of orders exceeds 100");
            Console.WriteLine("B: SELECT Clients.client_name FROM Clients INNER JOIN Orders ON Clients.client_id = Orders.client_id GROUP BY Clients.client_name HAVING SUM(Orders.order_sum) > 100;");

            Console.ReadKey();
        }
    }
}
