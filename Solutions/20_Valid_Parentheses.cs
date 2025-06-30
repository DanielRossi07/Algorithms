//https://leetcode.com/problems/valid-parentheses/description/

public static class Valid_Parentheses
{
    public static bool IsValid(string s)
    {
        var openChars = new List<string> { "(", "[", "{" };
        var opens = new Stack<string>(); //LIFO
        var closeds = new Queue<string>(); //FIFO
        var pos = 0;

        while (pos < s.Length)
        {
            var currentChar = s[pos].ToString();
            var nextChar = "";

            if (pos + 1 < s.Length)
            {
                nextChar = s[pos + 1].ToString();
            }

            if (firstClosesSecond(currentChar, nextChar))
            {
                pos += 2;
                continue;
            }

            if (openChars.Contains(currentChar))
            {
                opens.Push(currentChar);
            }
            else
            {
                if (pos != s.Length - 1)
                {
                    var lastOpen = string.Empty;
                    opens.TryPeek(out lastOpen);

                    if (!firstClosesSecond(lastOpen, currentChar))
                    {
                        return false;
                    }
                    else
                    {
                        opens.Pop();
                        pos += 1;
                        continue;
                    }
                }
                
                closeds.Enqueue(currentChar);
            }

            pos += 1;
        }

        if (opens.Count() != closeds.Count())
        {
            return false;
        }

        for (pos = 0; pos < opens.Count(); pos++)
        {
            if (!firstClosesSecond(opens.Pop(), closeds.Dequeue()))
            {
                return false;
            }
        }

        return true;
    }

    private static bool firstClosesSecond(string first, string second)
    {
        if (first == "(" && second == ")")
        {
            return true;
        }
        else if (first == "[" && second == "]")
        {
            return true;
        }
        else if (first == "{" && second == "}")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}