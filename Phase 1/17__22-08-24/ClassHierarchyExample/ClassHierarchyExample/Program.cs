using System;
using System.Collections.Generic;


/* Student
 * - Name
 * - Scores
 *     - Subject
 *     - Scored Mark
 *     - Exam Name
 */
namespace ClassHierarchyExample
{
    class Score
    {
        public string Subject { get; set; }
        public string ExamName { get; set; }
        public int ScoredMark { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public Score[] Scores { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var ann = new Student
            {
                Name = "Ann Maria",
                Scores = new Score[]
                {
                    new Score {ExamName="Term 1", Subject="English", ScoredMark=40 },
                    new Score {ExamName="Term 1", Subject="Malayalam", ScoredMark=45 },
                }
            };

            var rosh = new Student();
            rosh.Name = "Roshann Andrews";
            rosh.Scores = new Score[2];
            rosh.Scores[0] = new Score { ExamName = "Term1", Subject = "English", ScoredMark = 50 };
            rosh.Scores[1] = new Score { ExamName = "Term1", Subject = "Malayalam", ScoredMark = 35 };
        }
    }
}
