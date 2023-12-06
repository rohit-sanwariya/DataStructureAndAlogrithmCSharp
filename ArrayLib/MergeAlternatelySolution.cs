

namespace ArrayLib
{
    public class MergeAlternatelySolution

    {
        public MergeAlternatelySolution()
        {
            this.MergeAlternately("abcdef","pqrst");
        }
        public string MergeAlternately(string word1, string word2)
        {
            string output  = string.Empty;
            int x = 0;
            int y = 0;
            while (x< word1.Length && y< word2.Length)
            {
                bool curr = output.Length % 2 == 0;
                output += curr ? word1[x]:word2[y];
                if(curr)
                {
                    x++;
                }
                else
                {
                    y++;
                }
              
               
            }
            while (x < word1.Length)
            {
                output += word1[x];
                x++;
            }
            while (y < word2.Length)
            {
                output += word2[y];
                y++;
            }
            return output;
        }

    }
}
