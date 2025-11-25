public class Solution
{
    public long SumAndMultiply(int n)
    {
        // first build array of chars or something to hold non 0 integers,
        //filter out the 0s
        long x = 0;
        long sum = 0;

        string s = n.ToString();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c != '0')
            {
                int val = c - '0';

                x = x * 10 + val;

                sum += val;
            }
        }
        return sum * x;
    }
}
