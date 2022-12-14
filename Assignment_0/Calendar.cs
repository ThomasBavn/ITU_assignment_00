
namespace Assignment_0
{

    public class Calendar
    {

        public static bool IsLeapYear(int year)
        {
            if (year % 4 != 0) return false;
            if (year % 100 == 0 && year % 400 == 0) return true;
            return !(year % 100 == 0);

        }
        public static bool IsLeapWithDateTime(int i)
        {
            return DateTime.IsLeapYear(i);
        }

        // public static bool IsLeapYearNormalSwitch(int year)
        // {
        //     switch (year)
        //     {
        //         case int b when year % 4 == 0 && year >= 1:
        //             System.Console.WriteLine("i am int b: " + b);
        //             return true;
        //         default:
        //             return false;
        //     }
        // }

        // public static bool IsLeapYearEnhancedSwitch(int year)
        // {
        //     return true;
        //     return year switch
        //     {
        //         _ when year % 4 == 0 => true,
        //         _ => false,
        //     };
        // }



    }


}

