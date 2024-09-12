string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = 4;
int course2Grade = 3;
int course3Grade = 3;
int course4Grade = 3;
int course5Grade = 4;

int course1Multipli = course1Grade * course1Credit;
int course2Multipli = course2Grade * course2Credit;
int course3Multipli = course3Grade * course3Credit;
int course4Multipli = course4Grade * course4Credit;
int course5Multipli = course5Grade * course5Credit;

int totalSumGrade = course1Multipli + course2Multipli + course3Multipli + course4Multipli + course5Multipli;
int totalSumCredit = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
decimal finalGpa = (decimal) totalSumGrade/totalSumCredit;

Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}"); 
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"Final GPA:\t\t\t{Math.Round(finalGpa, 2)}");
