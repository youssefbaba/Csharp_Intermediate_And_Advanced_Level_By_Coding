namespace Interfaces_And_Inheritance
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            Console.WriteLine("Drag a textbox");
        }

        public void Drop()
        {
            Console.WriteLine("Drop a textbox");
        }
    }
}