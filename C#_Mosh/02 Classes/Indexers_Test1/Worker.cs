
namespace Indexers_Test1
{
    public class Worker
    {
        // Fields
        int _workerNumber; // by default acces modifier of field is private
        string _workerName;
        string _workerJob;
        string _departementName;
        string _departementLocation;
        double _salary;

        // Constructors
        public Worker(int workerNumber, string workerName, string workerJob, string departementName, string departementLocation, double salary)
        {
            _workerNumber = workerNumber;
            _workerName = workerName;
            _workerJob = workerJob;
            _departementName = departementName;
            _departementLocation = departementLocation;
            _salary = salary;
        }

        // Indexers
        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return _workerNumber;
                    case 1:
                        return _workerName;
                    case 2:
                        return _workerJob;
                    case 3:
                        return _departementName;
                    case 4:
                        return _departementLocation;
                    case 5:
                        return _salary;
                    default:
                        return null;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        _workerNumber = (int)value;  // unboxing
                        break;
                    case 1:
                        _workerName = (string)value;  // unboxing
                        break;
                    case 2:
                        _workerJob = (string)value;  // unboxing
                        break;
                    case 3:
                        _departementName = (string)value;  // unboxing
                        break;
                    case 4:
                        _departementLocation = (string)value;  // unboxing
                        break;
                    case 5:
                        _salary = (double)value;  // unboxing
                        break;
                    default:
                        break;
                }
            }
        }
        public object this[string key]
        {
            get
            {
                switch (key.ToLower())
                {
                    case "workernumber":
                        return _workerNumber;
                    case "workername":
                        return _workerName;
                    case "workerjob":
                        return _workerJob;
                    case "departementname":
                        return _departementName;
                    case "departementlocation":
                        return _departementLocation;
                    case "salary":
                        return _salary;
                    default:
                        return null;
                }
            }
            set
            {
                switch (key.ToLower())
                {
                    case "workernumber":
                        _workerNumber = (int)value;  // unboxing
                        break;
                    case "workername":
                        _workerName = (string)value;  // unboxing
                        break;
                    case "workerjob":
                        _workerJob = (string)value;  // unboxing
                        break;
                    case "departementname":
                        _departementName = (string)value;  // unboxing
                        break;
                    case "departementlocation":
                        _departementLocation = (string)value;  // unboxing
                        break;
                    case "salary":
                        _salary = (double)value;  // unboxing
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
