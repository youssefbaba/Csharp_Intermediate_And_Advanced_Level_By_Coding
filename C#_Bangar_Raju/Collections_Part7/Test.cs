namespace Collection_Part7
{
    public class Test
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { Id = 103, Name = "David", Class = 10, Marks = 550.50f };
            Student student2 = new Student { Id = 106, Name = "Jean", Class = 10, Marks = 489.65f };
            Student student3 = new Student { Id = 104, Name = "Jim", Class = 10, Marks = 510.14f };
            Student student4 = new Student { Id = 102, Name = "Gerard", Class = 10, Marks = 470.30f };
            Student student5 = new Student { Id = 101, Name = "Xavi", Class = 10, Marks = 536.48f };
            Student student6 = new Student { Id = 105, Name = "Marks", Class = 10, Marks = 513.47f };
            List<Student> students = new List<Student> { student1, student2, student3, student4, student5, student6 };
            Console.WriteLine("------ Display Students ------");


            /*
            Comparison<Student> comparison = Student.CompareMarks;  // Based on Marks
            students.Sort(comparison);
            */

  
            /*
            Comparison<Student> comparison = Student.CompareName;  // Based on Name
            students.Sort(comparison);
            */


            /*
            Comparison<Student> comparison = delegate (Student std1, Student std2)  // Anonymous method
            {
                return std1.Name.CompareTo(std2.Name);
            };
            students.Sort(comparison);
            */

            /*
            Comparison<Student> comparison = (std1, std2) => std1.Name.CompareTo(std2.Name);  // Lambda Expression
            students.Sort(comparison);
            */

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id} , {student.Name} , {student.Class} , {student.Marks}");
            }
            Console.WriteLine();


            List<Product> products = new List<Product>
            {
                new Product{ Id = 5 , Name = "Shirt" , Color = "Red" , Price = 119.99 },
                new Product{ Id = 2 , Name = "Cap" , Color = "Dark" , Price = 199.99 },
                new Product{ Id = 4 , Name = "Tie" , Color = "Blue" , Price = 149.99 },
                new Product{ Id = 7 , Name = "Shoes" , Color = "Yellow" , Price = 109.99 },
                new Product{ Id = 3 , Name = "Dress" , Color = "Green" , Price = 129.99 },
                new Product{ Id = 9 , Name = "Coat" , Color = "White" , Price = 99.99 },
            };
            Console.WriteLine("------ Display Products ------");
            products.Sort(); // Based on Price
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id} , {product.Name} , {product.Color} , {product.Price}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Display Products ------");
            CompareProduct compareProduct = new CompareProduct();
            products.Sort(1, 4, compareProduct); // Based on Name
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id} , {product.Name} , {product.Color} , {product.Price}");
            }
            Console.WriteLine();





        }
    }
}