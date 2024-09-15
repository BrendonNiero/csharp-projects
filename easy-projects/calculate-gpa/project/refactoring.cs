string studentName = "Sophia Johnson";

string[] courseName = { "English 101", "Algebra 101", "Biology 101", "Computer Science I ", "Psychology 101" };

int[] courseCredit = { 3, 3, 4, 4, 2 };
int[] courseGrade = { 4, 3, 3, 3, 4 };
int[] courseMultipli = new int[5];

int totalSumGrade = 0;
int totalSumCredit = 0;

for(int i = 0; i < 5; i++){
    courseMultipli[i] = courseGrade[i] + courseGrade[i];
    totalSumGrade += courseMultipli[i];
    totalSumCredit += courseCredit[i];
};

decimal finalGpa = (decimal) totalSumGrade/totalSumCredit;

Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

for(int i = 0; i < 5; i++){
    Console.WriteLine($"{courseGrade[i]}\t\t\t{courseGrade[i]}\t\t\t{courseCredit[i]}");
};

Console.WriteLine($"Final GPA:\t\t\t{Math.Round(finalGpa, 2)}");