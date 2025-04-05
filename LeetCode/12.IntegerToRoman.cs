namespace LeetCode 
{
    public static partial class Problems
    {
        public static string IntegerToRoman_12(int num) {
            if (num >= 4000 || 0 >= num) {
                return "Out of range";
            }

            Dictionary<int,string> Symbols = new Dictionary<int, string> {
                [1000] = "M",
                [900] = "CM",
                [500] = "D",
                [400] = "CD",
                [100] = "C",
                [90] = "XC",
                [50] = "L",
                [40] = "XL",
                [10] = "X",
                [9] = "IX",
                [5] = "V",
                [4] = "IV",
                [1] = "I"
            };

            string output = "";
            foreach (var s in Symbols) {
                while (num - s.Key >= 0) {
                    output += s.Value;
                    num -= s.Key;}}
            return output;
        } 
    }
}

