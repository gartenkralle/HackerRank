public Difference(int[] a)
{
    elements = a;
}

public void computeDifference()
{
    for (int i = 0; i < (elements.Length - 1); i++)
    {
        for (int j = (i + 1); j < elements.Length; j++)
        {
            int currentDifference = Math.Abs(elements[i] - elements[j]);

            if (currentDifference > maximumDifference)
                maximumDifference = currentDifference;
        }
    }
}
