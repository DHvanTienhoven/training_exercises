using System;

namespace JobsExercise
{
    public class OfficeClerk : Worker
    {
        public void TypeSomething(string text)
        {
            Console.WriteLine("Typing: {0}", text);
        }
    }
}
