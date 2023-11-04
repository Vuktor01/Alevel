public class Gift
{
    private ISweet[] sweets = new ISweet[0];
    private int count = 0;

    public void AddSweet(ISweet sweet)
    {
        Array.Resize(ref sweets, count + 1);
        sweets[count] = sweet;
        count++;
    }

    public double GetTotalWeight()
    {
        double totalWeight = 0;
        foreach (var sweet in sweets)
        {
            totalWeight += sweet.Weight;
        }
        return totalWeight;
    }

    public ISweet[] SortBySugarContent()
    {
        Array.Sort(sweets, (s1, s2) => s1.SugarContent.CompareTo(s2.SugarContent));
        return sweets;
    }

    public ISweet FindSweetByCriteria(Func<ISweet, bool> criteria)
    {
        return sweets.FirstOrDefault(criteria);
    }
}