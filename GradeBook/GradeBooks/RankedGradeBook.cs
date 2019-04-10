using GradeBook.Enums;
using System;


namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count >= 5)
            {
                if (averageGrade >= 80)
                {
                    return 'A';
                }
                else if (averageGrade < 80 && averageGrade > 60)
                {
                    return 'B';
                }
                else if (averageGrade < 60 && averageGrade > 40)
                {
                    return 'C';
                }
                else if (averageGrade < 40 && averageGrade > 20)
                {
                    return 'D';
                }
                else
                {
                    return 'F';
                }
            }
            else
            {
                throw new InvalidOperationException();
            }

        }

        public override void CalculateStatistics()
        {
            if(Students.Count >=5)
            base.CalculateStatistics();
            else
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if(Students.Count>=5)
            base.CalculateStudentStatistics(name);
            else
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
        }
    }
}
