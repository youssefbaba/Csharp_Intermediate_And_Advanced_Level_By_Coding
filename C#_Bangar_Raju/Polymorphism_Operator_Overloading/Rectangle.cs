
using System.Runtime.CompilerServices;

namespace Polymorphism_Operator_Overloading
{
    internal class Rectangle
    {
        // Fields
        public int Width;
        public int Height;

        // Constructors
        public Rectangle()
        {
        }
        public Rectangle(int width , int height)
        {
            Width = width;
            Height = height;    
        }
        // Methods

        // <modifiers> <return type> operator <opt>(<parameters list>){ // Statements }
        public static Rectangle operator +(Rectangle rectangle1, Rectangle rectangle2)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = rectangle1.Width + rectangle2.Width;
            rectangle.Height = rectangle1.Height + rectangle2.Height;
            return rectangle;
        }
        public static Rectangle operator *(Rectangle rectangle1, Rectangle rectangle2)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = rectangle1.Width * rectangle2.Width;
            rectangle.Height = rectangle1.Height * rectangle2.Height;
            return rectangle;
        }
        public static Rectangle operator ++(Rectangle rectangle1)
        {
            rectangle1.Width++;
            rectangle1.Height++;
            return rectangle1;
        }
        public static Rectangle operator --(Rectangle rectangle1)
        {
            rectangle1.Width--;
            rectangle1.Height--;
            return rectangle1;
        }
        public static bool operator <= (Rectangle rectangle1 , Rectangle rectangle2)
        {
            if ((rectangle1.Width <= rectangle2.Width) && (rectangle1.Height <= rectangle2.Height))
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(Rectangle rectangle1, Rectangle rectangle2)
        {
            return !(rectangle1 < rectangle2);
        }
        public static bool operator <(Rectangle rectangle1, Rectangle rectangle2)
        {
            if ((rectangle1.Width < rectangle2.Width) && (rectangle1.Height < rectangle2.Height))
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Rectangle rectangle1, Rectangle rectangle2)
        {
            return !(rectangle1 <= rectangle2);
        }
        public static bool operator == (Rectangle rectangle1 , Rectangle rectangle2)
        {
            if ((rectangle1.Width == rectangle2.Width) && (rectangle1.Height == rectangle2.Height))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Rectangle rectangle1, Rectangle rectangle2)
        {
            return !(rectangle1 == rectangle2);
        }

        // Implicit Casting Operator form integer to Rectange type
        public static implicit operator Rectangle( int value)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = value;
            rectangle.Height = value;
            return rectangle;
        }

        // Explicit Casting operator from Rectangle type to string
        public static explicit operator string(Rectangle rectangle)
        {
            return $"Width = {rectangle.Width} , Height = {rectangle.Height}";
        }


        public override string ToString()
        {
            return $"Width = {Width} , Height = {Height}"; 
        }
    }
}
