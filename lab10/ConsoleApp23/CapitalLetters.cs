namespace ConsoleApp8
{
    public class CapitalLetters
    {
        public string ToCapital(string str)
        {
            char[] split = str.ToCharArray();
            split[0] = char.ToUpper(split[0]);
            for (int n = 0; n < split.Length - 1; n++)
            {
                if (split[n] == ' ')
                {
                    split[n + 1] = char.ToUpper(split[n + 1]);
                }
            }

            string result = new string(split);
            return result;
        }
    }
}