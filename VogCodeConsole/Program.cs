using System;

namespace VogCodeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // I would usually use method #2, for situations like this,
            // but since it may be considered a loop I showed both..

            // method #1
            Console.WriteLine(string.Join(Environment.NewLine, QuestionClass.NameList));

            // method #2
            //QuestionClass.NameList.ForEach(Console.WriteLine);
        }
    }
}
