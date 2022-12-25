using System.Collections;

namespace Collections_Part8
{
    public class OrganizationEnumerator : IEnumerator
    {
        // Fields
        Organization _orgColl;
        int _currentIndex;
        Employee _currentEmployee;


        // Constructors
        public OrganizationEnumerator(Organization org)
        {
            _orgColl = org;
            _currentIndex = -1;

        }


        // Methods
        public bool MoveNext()
        {
            if (++_currentIndex >= _orgColl.Counter)
            {
                return false;
            }
            else
            {
                _currentEmployee = _orgColl[_currentIndex];
                return true;
            }
        }
        public void Reset()
        {
        }


        // Properties
        public object Current
        {
            get
            {
                return _currentEmployee;
            }
        }
    }
}
