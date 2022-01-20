using System.Collections.Generic;

namespace VogCodeConsole
{
    public static class QuestionClass
    {
        public static List<string> NameList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };


        // Method for Question #8
        public static object TESTModule(object value)
        {
            switch (value)
            {
                case int n when (n <= 4 && n >= 1):
                    return n *= 2;
                case int n when (n > 4):
                    return n *= 3;
                case int n when (n < 1):
                    throw new System.ArgumentOutOfRangeException("TESTModule parameter value is below 1");
                case float n when (n == 1.0f || n == 2.0f):
                    return 3.0f;
                case string s:
                    return s.ToUpper();
                default:
                    return value;
            }
        }
    }
}
