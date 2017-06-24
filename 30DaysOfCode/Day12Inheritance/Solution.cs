class Student : Person
{
    private int[] testScores;

    public Student(String fname, String lname, int p, int[] s) : base(fname, lname, p)
    {
        testScores = s;
    }

    public char Calculate()
    {
        int score = testScores.Sum() / testScores.Length;

        if (score < 40)
            return 'T';
        else if ((score >= 40) && (score < 55))
            return 'D';
        else if ((score >= 55) && (score < 70))
            return 'P';
        else if ((score >= 70) && (score < 80))
            return 'A';
        else if ((score >= 80) && (score < 90))
            return 'E';
        else if ((score >= 90) && (score <= 100))
            return 'O';

        return '-';
    }
}
