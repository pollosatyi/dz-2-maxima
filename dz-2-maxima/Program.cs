using System.Collections.Specialized;

namespace dz_2_maxima
{
    
    internal class Program
    {

        public static List<List<string>> PodSpisok(string s)
        {
            var podSpisoks = new List<List<string>>();
            podSpisoks.Add(new List<string>() {""});
            string[]spisok = s.Split(' ');
            for (int i = 0; i < spisok.Length; i++)
            {
                var spisokTemp = new List<string>();
                for(int j = i; j < spisok.Length; j++)
                {
                    spisokTemp.Add(spisok[j]);
                }
                podSpisoks.Add(spisokTemp);
            }
            return podSpisoks;
        }
        

        public static void PrintSpisok(List<List<string>>podSpisoks)
        {
            Console.Write("[");
            for(int i = 0; i < podSpisoks.Count; i++)
            {
                for(int j = 0; j < podSpisoks[i].Count; j++)
                {

                }
            }
            Console.Write("]");
        }

        static void Main(string[] args)
        {
            
            PrintSpisok(PodSpisok("a b"));
            
        }
    }
}
