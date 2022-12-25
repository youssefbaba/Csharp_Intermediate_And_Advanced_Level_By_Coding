namespace Generic_Queue_Collection_Class
{
    public class Test
    {
        static void Main(string[] args)
        {
            /*
             - Queue is FIFO generic collection class that is present in System.Collections.Generic
             */
            Product product1 = new Product { Id = 101, Name = "Dress" , Price = 199.99};
            Product product2 = new Product { Id = 102, Name = "Jacket" , Price = 399.99 };
            Product product3 = new Product { Id = 103, Name = "Hat" , Price = 19.99 };
            Product product4 = new Product { Id = 104, Name = "Blouse" , Price = 99.99};
            Product product5 = new Product { Id = 105, Name = "Vest"  , Price = 159.99};


            Queue<Product> queueProducts = new Queue<Product>();


            Console.WriteLine("------ Adding the items to the begining of the queueProducts Queue and display them ------");
            queueProducts.Enqueue(product5); // Adds an item to the ends of the queueProducts Queue
            queueProducts.Enqueue(product3); // Adds an item to the ends of the queueProducts Queue
            queueProducts.Enqueue(product4); // Adds an item to the ends of the queueProducts Queue
            queueProducts.Enqueue(product2); // Adds an item to the ends of the queueProducts Queue
            queueProducts.Enqueue(product1); // Adds an item to the ends of the queueProducts Queue
            Console.WriteLine($"Total items in the queueProducts Queue : {queueProducts.Count}");
            foreach (Product product in queueProducts)
            {
                Console.WriteLine($"Id = {product.Id} , Name = {product.Name} , Price = {product.Price}");
            }
            Console.WriteLine();


            Product product6 =  queueProducts.Dequeue(); // Removes and returns the item at the begining of the queueProducts Queue
            Console.WriteLine($"Id = {product6.Id} , Name = {product6.Name} , Price = {product6.Price}");
            Console.WriteLine($"Total items left in the queueProducts Queue : {queueProducts.Count}");
            Console.WriteLine();


            Product product7 = queueProducts.Dequeue(); // Removes and returns the item at the begining of the queueProducts Queue
            Console.WriteLine($"Id = {product7.Id} , Name = {product7.Name} , Price = {product7.Price}");
            Console.WriteLine($"Total items left in the queueProducts Queue : {queueProducts.Count}");
            Console.WriteLine();


            Product product8 = queueProducts.Dequeue(); // Removes and returns the item at the begining of the queueProducts Queue
            Console.WriteLine($"Id = {product8.Id} , Name = {product8.Name} , Price = {product8.Price}");
            Console.WriteLine($"Total items left in the queueProducts Queue : {queueProducts.Count}");
            Console.WriteLine();


            Product product9 = queueProducts.Dequeue(); // Removes and returns the item at the begining of the queueProducts Queue
            Console.WriteLine($"Id = {product9.Id} , Name = {product9.Name} , Price = {product9.Price}");
            Console.WriteLine($"Total items left in the queueProducts Queue : {queueProducts.Count}");
            Console.WriteLine();


            Product product10 = queueProducts.Dequeue(); // Removes and returns the item at the begining of the queueProducts Queue
            Console.WriteLine($"Id = {product10.Id} , Name = {product10.Name} , Price = {product10.Price}");
            Console.WriteLine($"Total items left in the queueProducts Queue : {queueProducts.Count}");
            Console.WriteLine();


            Console.WriteLine("------ Adding the items to the begining of the queueProducts Queue and display them ------");
            queueProducts.Enqueue(product1); // Adds an item to the ends of the queueProducts Queue
            queueProducts.Enqueue(product2); // Adds an item to the ends of the queueProducts Queue
            queueProducts.Enqueue(product3); // Adds an item to the ends of the queueProducts Queue
            queueProducts.Enqueue(product4); // Adds an item to the ends of the queueProducts Queue
            queueProducts.Enqueue(product5); // Adds an item to the ends of the queueProducts Queue
            Console.WriteLine($"Total items in the queueProducts Queue : {queueProducts.Count}");
            foreach (Product product in queueProducts)
            {
                Console.WriteLine($"Id = {product.Id} , Name = {product.Name} , Price = {product.Price}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Getting an item at the begining of the queueProducts Queue without removing it ------");
            Product product11=  queueProducts.Peek(); // Return the item at the begining of the queueProducts Queue without removing it
            Console.WriteLine($"Id = {product11.Id} , Name = {product11.Name} , Price = {product11.Price}");
            Console.WriteLine($"Total items left in the queueProducts Queue : {queueProducts.Count}");
            Console.WriteLine();
            Product product12 = queueProducts.Peek(); // Return the item at the begining of the queueProducts Queue without removing it
            Console.WriteLine($"Id = {product12.Id} , Name = {product12.Name} , Price = {product12.Price}");
            Console.WriteLine($"Total items left in the queueProducts Queue : {queueProducts.Count}");
            Console.WriteLine();


            Console.WriteLine("------ Checking if the specific item is found in the queueProducts Queue ------");
            Product product40 = default;
            if (queueProducts.Contains(product4))
            {
                Console.WriteLine("product4 exists in the queueProducts Queue");
            }
            else
            {
                Console.WriteLine("product4 doesn't exist in the queueProducts Queue");
            }
            Console.WriteLine();
            if (queueProducts.Contains(product40))
            {
                Console.WriteLine("product40 exists in the queueProducts Queue");
            }
            else
            {
                Console.WriteLine("product40 doesn't exist in the queueProducts Queue");
            }

        }
    }
}