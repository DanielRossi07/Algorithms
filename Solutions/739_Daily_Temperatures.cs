public class Daily_Temperatures
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var results = new int[temperatures.Length];

        for (var currentPos = 0; currentPos < temperatures.Length; currentPos++)
        {
            if (currentPos + 1 == temperatures.Length)
            {
                results[currentPos] = 0;
                return results;
            }

            var noWarmerDay = true;
            var currentTemp = temperatures[currentPos];
            for (var pos = currentPos + 1; pos < temperatures.Length; pos++)
            {
                var nextTemp = temperatures[pos];
                if (currentTemp < nextTemp)
                {
                    results[currentPos] = pos - currentPos;
                    noWarmerDay = false;
                    break;
                }
            }

            if (noWarmerDay)
                results[currentPos] = 0;
        }

        return results;
    }
}