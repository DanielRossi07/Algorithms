//https://leetcode.com/problems/valid-anagram/description/
namespace Algorithms.Solutions
{
    public class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            var sHash = new Dictionary<char, int>();
            var tHash = new Dictionary<char, int>();

            if (s.Length != t.Length)
            {
                return false;
            }

            for (var pos = 0; pos < s.Length; pos++)
            {
                int amountOfCharInS;
                sHash.TryGetValue(s[pos], out amountOfCharInS);

                if (amountOfCharInS != 0)
                {
                    sHash[s[pos]] = amountOfCharInS + 1;
                }
                else
                {
                    sHash.Add(s[pos], 1);
                }
                    

                int amountOfCharInT;
                tHash.TryGetValue(t[pos], out amountOfCharInT);

                if (amountOfCharInT != 0)
                {
                    tHash[t[pos]] = amountOfCharInT + 1;
                }
                else
                {
                    tHash.Add(t[pos], 1);
                }
                    
            }

            foreach (var distChar in sHash.Keys.Distinct())
            {
                int amountOfCharInS;
                sHash.TryGetValue(distChar, out amountOfCharInS);

                int amountOfCharInT;
                tHash.TryGetValue(distChar, out amountOfCharInT);

                if (amountOfCharInS != amountOfCharInT)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
