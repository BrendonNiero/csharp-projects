string studentName = "Sophia Johnson";

string[] courseName = { "English 101", "Algebra 101", "Biology 101", "Computer Science I ", "Psychology 101" };
int[] courseCredit = { 3, 3, 4, 4, 2 };
int[] courseGrade = { 4, 3, 3, 3, 4 };
int[] courseMultipli = { 
        (courseGrade[0] * courseCredit[0]), 
        (courseGrade[1] * courseCredit[1]),
        (courseGrade[2] * courseCredit[2]),
        (courseGrade[3] * courseCredit[3]),
        (courseGrade[4] * courseCredit[4])
        };

int totalSumGrade = courseMultipli[0] + courseMultipli[1] + courseMultipli[2] + courseMultipli[3] + courseMultipli[4];
int totalSumCredit = courseCredit[0] + courseCredit[1] + courseCredit[2] + courseCredit[3] + courseCredit[4];
decimal finalGpa = (decimal) totalSumGrade/totalSumCredit;

Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

for(int i = 0; i < 5; i++){
    Console.WriteLine($"{courseGrade[i]}\t\t\t{courseGrade[i]}\t\t\t{courseCredit[i]}");
};

Console.WriteLine($"Final GPA:\t\t\t{Math.Round(finalGpa, 2)}");