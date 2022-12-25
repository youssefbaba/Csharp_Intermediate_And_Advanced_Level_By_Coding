namespace Exceptions_Exception_Handling_Part1
{
    internal class Test
    {
        static void Main(string[] args)
        {
            /*
             1- Complie Time Errors => syntax error
             2- Run Time Errors  => Responsible for those errors is class Exception
                   - Wrong Implementation Of Logic
                   - Wrong Input Supplied
                   - Missing Required Resources
                        .
                        .
                        .

              - Exception : Is a class responsible of abnormal termination of a program whenever run time error occurs inside the program.
                    - IndexOutOfRangeException
                    - DivideByZeroException
                    - OverflowException
                    - FormatException
                        .
                        .
                        .
              - Exception (Parent Class) : - Presents logic for abnormal termination
                            - Contains a readonly property to display an error message which is declared as virtual "Message"
                    - Application Exception (Child Class) => Fatal Errors
                    - System Exception (Child Class) => Non Fatals Errors
                            - IndexOutOfRangeException
                            - FormatException
                            - ArithmeticException
                                    - DivideByZeroException
                                    - OverflowException
                                            .
                                            .
                                            .

                                        .
                                        .
                                        .
             */
        }
    }
}