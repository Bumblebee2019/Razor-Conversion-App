namespace CountApp.Models
{
    public class RomanNumber //Person
    {
        public int Id { get; set; }
        public string Roman { get; set; }
        public int RomanToArabic(string roman)
        {
            int result = 0;
            Dictionary<char, int> romanNumMap = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            char currChar;
            for (int i = 0; i < roman.Length; i++)
            {
                currChar = roman[i];
                romanNumMap.TryGetValue(currChar, out int current);
                if (i + 1 < roman.Length && romanNumMap[roman[i + 1]] > romanNumMap[currChar])
                {
                    result -= current;
                }
                else
                {
                    result += current;
                }
            }
            return result;
        }


    }
}

