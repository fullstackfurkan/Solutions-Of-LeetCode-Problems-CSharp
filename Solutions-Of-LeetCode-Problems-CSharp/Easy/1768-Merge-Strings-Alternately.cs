
namespace Solutions_Of_LeetCode_Problems_CSharp.Easy
{
    public class _1768_Merge_Strings_Alternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            string newString = "";
            int shortestWordLength = word1.Length < word2.Length ? word1.Length : word2.Length;
            string longestWord = word1.Length > word2.Length ? word1 : word2;
            int letterDifferenceCount = longestWord.Length - shortestWordLength;

            for (int i = 0; shortestWordLength > i; i++)
                newString += $"{word1[i]}{word2[i]}";

            if(word1.Length != word2.Length)
            {

            }
            //newString += $"{longestWord.Substring(letterDifferenceCount)}";

            Console.WriteLine(newString);

            return newString;
        }
    }
}
