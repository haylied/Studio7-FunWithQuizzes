using System;
namespace FunWIthQuizzes
{
	public class TrueFalse : Questions
	{
        public string? TFQuestion;
        public string? TFChoices;
        public string? TFAnswer;

        public override string AskQuestions()
        {
            TFQuestion = "True/False: A tomato is a vegetable.";
            return TFQuestion;
        }

        public override string DisplayChoices()
        {
            TFChoices = "True or False";
            return TFChoices;
        } 

        public override string CorrectAnswer()
        {
            TFAnswer = "False";
            return TFAnswer;
        }
    }
}

