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
                var amountOfCharInS = sHash[s[pos]];
                sHash.Add(s[pos], amountOfCharInS + 1);

                var amountOfCharInT = tHash[t[pos]];
                tHash.Add(t[pos], amountOfCharInT + 1);
            }

            foreach (var distChar in sHash.Keys.Distinct())
            {
                if (sHash[distChar] != tHash[distChar])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
