using System;
namespace FunWIthQuizzes
{
	public class CheckBox : Questions
	{
        public string? CheckBoxQuestion;
        public string? CheckBoxChoices;
        public string? CheckBoxAnswer;

        public override string AskQuestions()
        {
            CheckBoxQuestion = "Which of these are prime numbers?";
            return CheckBoxQuestion;
        }

        public override string DisplayChoices()
        {
            CheckBoxChoices = "A. 27" + Environment.NewLine + "B. 19" + Environment.NewLine + "C. 15" + Environment.NewLine + "D. 31";
            return CheckBoxChoices;
        }

        public override string CorrectAnswer()
        {
            CheckBoxAnswer = "B, D";
            return CheckBoxAnswer;
        }
    }
}

