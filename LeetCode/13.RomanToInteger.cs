namespace LeetCode 
{
    public static partial class Problems
    {
        public static int RomanToInteger_13(string s) {
            Dictionary<char, int> Symbols = new Dictionary<char, int> {
                ['M'] = 1000,
                ['D'] = 500,
                ['C'] = 100,
                ['L'] = 50,
                ['X'] = 10,
                ['V'] = 5,
                ['I'] = 1
            };

            int output = 0;
            for (int i = 0; i < s.Length; i++) {
                if (i != s.Length-1 && Symbols[s[i]] < Symbols[s[i+1]]) {
                    output += Symbols[s[i+1]] - Symbols[s[i]];
                    i++;
                } else {
                    output += Symbols[s[i]];
                }
            }
            return output;
        }
    }
}