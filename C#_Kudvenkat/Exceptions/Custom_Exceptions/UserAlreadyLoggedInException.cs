using System.Runtime.Serialization;

namespace Custom_Exceptions
{
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {

        // Constructors
        public UserAlreadyLoggedInException():base("User is logged in - no duplicate session allowed.")
        {
        }
        public UserAlreadyLoggedInException(string message):base(message)
        {
        }
        public UserAlreadyLoggedInException(string message , Exception innerException) : base(message , innerException)
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) :base(info, context)
        {
        }


    }
}
