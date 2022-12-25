namespace IComparable_IComparer_Interfaces_Part0
{
    public class CompareCar : IComparer<Car>
    {
        // Methods
        public int Compare(Car? car1, Car? car2)
        {
            return car1.Color.CompareTo(car2.Color);
        }
    }
}
