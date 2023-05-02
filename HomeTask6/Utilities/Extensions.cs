namespace HomeTask6.Utilities;

public static class Extensions
{
    public static int MatchCount(this string str, string substr)
    {
        int count = 0;
        int startIndex = 0;

        while (str.Substring(startIndex).Contains(substr)) 
        {
            count++;
            startIndex = str.IndexOf(substr,startIndex) + substr.Length; 
        }
        return count;
    }
}

