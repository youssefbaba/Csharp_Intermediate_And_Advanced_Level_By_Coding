namespace Enumeration_Enum__Types
{
    public enum Days  // <modifiers> <enum keyword> <name> { - list of named constant values. } and the default type for the values represented in enum is an integer
    {
        Monday,     // default value is 0
        Tuesday,    // default value is 1
        Wednesday,  // default value is 2
        Thursday,   // default value is 3
        Friday,     // default value is 4
    }

    public enum Seasons // <modifiers> <enum keyword> <name> { - list of named constant values. } and the default type for the values represented in enum is an integer
    {
        Autum = 1,      // its value is 1
        Winter = 11,    // its value is 11
        Spring,         // its value is 12
        Summer = 41,    // its value is 41
    }

    public enum Levels : byte
    {
        Low,
        Medium,
        High
    }

    public class Enumeration
    {
        // Properties
        //public Days MeetingDate { get; set; } = 0;
        public Days MeetingDate { get; set; } = Days.Monday;
    }
}
