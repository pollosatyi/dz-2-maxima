namespace dz_2_maxima
{
    
    internal class Program
    {
        public static List<List<string>> Chunked(List<string> list, int n)
        {
           var newList= new List<List<string>>();
            
            for(int i=0;i<list.Count;i++)
            {
                List<string> chunks = new List<string>();
                for (int j = i; j < n; j++)
                {
                    chunks.Add(list[i]);
                }
                newList.Add(chunks);
            }
            return newList;
        }
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "a","b","c","d","e","f" };
            int n = 2;
            var chunked = Chunked(list, n);
        }
    }
}
