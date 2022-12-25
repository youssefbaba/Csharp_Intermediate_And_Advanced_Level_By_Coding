
namespace Polymorphism_Operator_Overloading
{
    internal class Operators
    {
        static void Main()
        {
            /*
                  - Arithmetic operators : those operators supported by integral and floating-point numeric types and char type also + is supported by string type .
                        - Unary ++ (increment), -- (decrement), + (plus), and - (minus) operators
                        - Binary * (multiplication), / (division), % (remainder), + (addition), and - (subtraction) operators
                        - In the case of char operands, the corresponding character codes are compared.

                  - Comparison operators : those operators supported by integral and floating-point numeric types and char type and ( == , != ) supported by string type .
                        - < (less than), > (greater than), <= (less than or equal), and >= (greater than or equal) 
                        - == and != operators 
                        - In the case of char operands, the corresponding character codes are compared.

                  - Boolean logical operators :  those operators supported by bool type.
                        - Unary ! (logical negation) operator.
                        - Binary & (logical AND), | (logical OR), and ^ (logical exclusive OR) operators. Those operators always evaluate both operands.
                        - Binary && (conditional logical AND) and || (conditional logical OR) operators. Those operators evaluate the right-hand operand only if it's necessary.
                        - For operands of the integral numeric types, the &, |, and ^ operators perform bitwise logical operations.

            */

            
           
            char a = 'a'; // 97 
            char b = 'b'; // 98
            Console.WriteLine(a--);
            Console.WriteLine(b++);
            Console.WriteLine(-a);
            Console.WriteLine(+b);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            string s1 = "Hello";
            string s2 = "World";
            Console.WriteLine(s1 + s2);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 != s2);

        }
    }
}

