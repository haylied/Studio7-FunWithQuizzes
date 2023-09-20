using System;
namespace FunWIthQuizzes
{
	public class MultipleChoice : Questions
    {
		public string? MCQuestion;
        public string? MCChoices;
        public string? MCAnswer;

        public override string AskQuestions() 
		{
			MCQuestion = "What is the fastest selling book of all time?";
			return MCQuestion;
        }

        public override string DisplayChoices()
        {
            MCChoices ="A. Harry Potter & The Deathly Hallows" + Environment.NewLine +
                "B. The Hunger Games" + Environment.NewLine +
                "C. Breaking Dawn (Twilight Series)";
            return MCChoices;
        }

        public override string CorrectAnswer()
        {
            MCAnswer = "A";
            return MCAnswer;
        }
    }
}

