using System.Collections;

namespace Generics_Part1
{
    public class Salaries
    {
        // Fields
        //private ArrayList _salaryList = new ArrayList();
        private List<float> _salaryList = new List<float>();

        // Constructors
        public Salaries()
        {
            /* 
             _salaryList.Add(60000.34);  // Boxing
             _salaryList.Add(40000.51);  // Boxing
             _salaryList.Add(20000.25);  // Boxing
            */
            _salaryList.Add(60000.34f);
            _salaryList.Add(40000.51f);
            _salaryList.Add(20000.25f);
        }

        // Methods
        //public ArrayList GetSalaries()
        public List<float> GetSalaries()
        {
            return _salaryList;
        }
    }
}
