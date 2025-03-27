using System;

class StudentGrades
{
    static void Main()
    {
       
        int[,] grades = new int[5, 3]
        {
          {85, 76, 88},  //S1
          {78, 92, 84},  //S2
          {94, 83, 91},  //S3
          {81, 80, 96},  //S4
          {80, 95, 90}   //S5
        };

        Console.WriteLine("Grades Matrix:\n");
        DisplayGradesMatrix(grades);

        Console.WriteLine("\nAverage Grades per Student:\n");
        CalculateStudentAverages(grades);

        Console.WriteLine("\nHighest Grades per Subject:\n");
        FindSubjectHighest(grades);

        Console.WriteLine("\nPress any key to exit...\n");
        Console.ReadKey();
    }

    static void DisplayGradesMatrix(int[,] grades)
    {
        int studentCount = grades.GetLength(0);
        int subjectCount = grades.GetLength(1);

        for (int i = 0; i < studentCount; i++)
        {
            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write($"{grades[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    static void CalculateStudentAverages(int[,] grades)
    {
        int studentCount = grades.GetLength(0);
        int subjectCount = grades.GetLength(1);

        for (int i = 0; i < studentCount; i++)
        {
            int sum = 0;
            for (int j = 0; j < subjectCount; j++)
            {
                sum += grades[i, j];
            }
            double average = (double)sum / subjectCount;
            Console.WriteLine($"Student {i + 1}: {average:F0}");
        }
    }

    static void FindSubjectHighest(int[,] grades)
    {
        int studentCount = grades.GetLength(0);
        int subjectCount = grades.GetLength(1);

        for (int j = 0; j < subjectCount; j++)
        {
            int highest = grades[0, j];
            for (int i = 1; i < studentCount; i++)
            {
                if (grades[i, j] > highest)
                {
                    highest = grades[i, j];
                }
            }
            Console.WriteLine($"Subject {j + 1}: {highest:F0}");
        }
    }
}
