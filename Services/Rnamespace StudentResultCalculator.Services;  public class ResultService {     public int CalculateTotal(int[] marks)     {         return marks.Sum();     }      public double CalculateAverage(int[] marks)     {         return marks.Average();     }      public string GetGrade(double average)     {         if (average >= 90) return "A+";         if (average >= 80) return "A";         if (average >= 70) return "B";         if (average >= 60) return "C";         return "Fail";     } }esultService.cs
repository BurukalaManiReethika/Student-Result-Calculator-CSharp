namespace StudentResultCalculator.Services;

public class ResultService
{
    public int CalculateTotal(int[] marks)
    {
        return marks.Sum();
    }

    public double CalculateAverage(int[] marks)
    {
        return marks.Average();
    }

    public string GetGrade(double average)
    {
        if (average >= 90) return "A+";
        if (average >= 80) return "A";
        if (average >= 70) return "B";
        if (average >= 60) return "C";
        return "Fail";
    }
}
