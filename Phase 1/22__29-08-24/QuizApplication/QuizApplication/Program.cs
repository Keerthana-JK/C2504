//prepare quiz opn
//add qn/attempt test
//qn - 4 answers
//select 1 answer show if correct
//randomly pick 10 qns
//display score
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using static QuizApplication.Program;


namespace QuizApplication
{
    internal class Program
    {
        public class QuizMaster
        {
            public QuizMaster()
            {
            }

            //public int Totalquestions { get; set; }
            public string question { get; set; }
            public string answer { get; set; }
            public string option1 { get; set; }
            public string option2 { get; set; }
            public string option3 { get; set; }
            public string option4 { get; set; }
            public void PrintQuestions()
            {
                Console.WriteLine($"Question: {question}, 1. {option1}, 2. {option2}, 3. {option3}, 4. {option4}");
            }
        }

        public class Attender
        {

        }
        //public class Options
        //{
        //    public string option { get; set; }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1 for Quizzer & 2. to attempt Quiz");
            int user = int.Parse(Console.ReadLine());
            if ((user != 1) && (user != 2))
            {
                Console.WriteLine("Enter either 1 or 2");
            }
            if (user == 1)
            {
                Console.WriteLine("Enter the number of questions you want to provide");
                int n = int.Parse(Console.ReadLine());
                QuizMaster qm = new QuizMaster();
                List<QuizMaster> questions = new List<QuizMaster>();
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Enter question {i}: ");
                    qm.question = Console.ReadLine();
                    Console.WriteLine("Enter options: ");
                    Console.WriteLine("Enter options 1: ");
                    qm.option1 = Console.ReadLine();
                    Console.WriteLine("Enter options 2: ");
                    qm.option2 = Console.ReadLine();
                    Console.WriteLine("Enter options 3: ");
                    qm.option3 = Console.ReadLine();
                    Console.WriteLine("Enter options 4: ");
                    qm.option4 = Console.ReadLine();

                   // Console.WriteLine("Which of these option is correct?");
                   // qm.answer= qm.option1;//for check
                }
            }
            if(user==2)
            {
                Console.WriteLine("Be ready to attempt the quiz");
                Console.WriteLine();
            }

            }
    }
}
