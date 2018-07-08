using System;

namespace TheAnsweringMachine
{
    public class TheMachine
    {
        public static Int32 GetTheAnswer(String question)
        {
            if (String.IsNullOrWhiteSpace(question))
            {
                throw new ArgumentNullException("Question may not be empty.");
            }

            return 42;
        }
    }
}
