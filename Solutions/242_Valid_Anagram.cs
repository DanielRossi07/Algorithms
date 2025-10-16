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

        public bool IsAnagram_Bettter(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var sHash = new Dictionary<char, int>();
            var tHash = new Dictionary<char, int>();

            for (int pos = 0; pos < s.Length; pos++)
            {
                if (sHash.TryGetValue(s[pos], out var countS))
                    sHash[s[pos]] = countS + 1;
                else
                    sHash[s[pos]] = 1;

                if (tHash.TryGetValue(t[pos], out var countT))
                    tHash[t[pos]] = countT + 1;
                else
                    tHash[t[pos]] = 1;
            }

            foreach (var key in sHash.Keys)
            {
                if (!tHash.TryGetValue(key, out var tCount) || sHash[key] != tCount)
                    return false;
            }

            return true;
        }

        public bool IsAnagram_Best(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var counts = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                counts[s[i]] = counts.GetValueOrDefault(s[i], 0) + 1;
                counts[t[i]] = counts.GetValueOrDefault(t[i], 0) - 1;
            }

            return counts.Values.All(v => v == 0);
        }
    }

}
