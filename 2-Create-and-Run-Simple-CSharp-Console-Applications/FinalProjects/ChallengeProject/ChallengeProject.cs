using System;

int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else
        continue;

    decimal sumAssignmentScores = 0;
    decimal currentStudentOverallGrade = 0;
    decimal currentStudentExamScoreAverage = 0;
    decimal currentStudentExtraCreditScoreAverage = 0;
    decimal currentStudentExtraCreditPoints = 0;
    var examScores = studentScores.Take(5);
    int gradedAssignments = 0;
    int extraCreditAssignments = 0;
    int sumExtraCreditScores = 0;

    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            // add the exam score to the sum
            sumAssignmentScores += score;
        }
        else
        {
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10.0m;
            sumExtraCreditScores += score;
            extraCreditAssignments += 1;
        }
    }
    currentStudentOverallGrade = (decimal)(sumAssignmentScores) / examAssignments;
    currentStudentExamScoreAverage = examScores.Sum() / (decimal)examAssignments;
    currentStudentExtraCreditScoreAverage = sumExtraCreditScores / extraCreditAssignments;
    currentStudentExtraCreditPoints = (decimal)(sumExtraCreditScores) / examAssignments / 10.0m;

    if (currentStudentOverallGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentOverallGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentOverallGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentOverallGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentOverallGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentOverallGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentOverallGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentOverallGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentOverallGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentOverallGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentOverallGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentOverallGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScoreAverage}\t\t{currentStudentOverallGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScoreAverage} ({currentStudentExtraCreditPoints} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();