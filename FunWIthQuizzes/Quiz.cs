using System;
namespace FunWIthQuizzes
{
    public class Quiz
    {
        public List<string>? ListOfQuestions;
        public List<string>? ListOfChoices;
        public List<string>? ListOfAnswers;
        public List<string>? ListOfUserInput;
        public int Score = 0;

        public List<string> StoreUserInput(string userinput) // get user input from each question and store in list
        {
            ListOfUserInput.Add(userinput);
            return ListOfUserInput;
        }

        public List<string> StoreQuestions(string questionType)
        {
            ListOfQuestions.Add(questionType);
            return ListOfQuestions;

        }

        public List<string> StoreAnswers(string answer)
        {
            ListOfAnswers.Add(answer);
            return ListOfAnswers;

        }

        public List<string> StoreChoices(string answerOptions)
        {
            ListOfChoices.Add(answerOptions);
            return ListOfChoices;

        }

        public int GetScore() 
            {
            // Take the List of Answers and compare them with a list of user input answers
           
            // Loop through each list to aquire the correct user input to answer combo.. store in a score variable
                for (int index = 0; index < ListOfQuestions.Count; index++)
                {
                    if (ListOfUserInput[index] == ListOfAnswers[index])
                    {
                        Score += 1;
                    }
                    else
                    {
                        Score += 0;
                    }
                }
                return Score;
            }


        public string GradeQuiz()
        {
            string score = string.ToString(Score);
            string congrats = Console.WriteLine("Congratulations! You scored a " + score + " out of " + ListOfQuestions.Count + "!");
            return congrats;

        }

      
    }
}
