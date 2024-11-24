namespace dz_2_maxima
{
    
    internal class Program
    {
        public static void PrintSpisok(List<List<string>>podSpisoks)
        {
            Console.Write("[");
            for(int i = 0; i < podSpisoks.Count; i++)
            {
                Console.Write("[");
                for(int j = 0; j < podSpisoks[i].Count; j++)
                {
                    Console.Write("\'"+podSpisoks[i][j]+"\'");
                    if (j < podSpisoks[i].Count-1)Console.Write(", ");
                }
                Console.Write("]");
            }
            Console.Write("]");
        }
        static void Main(string[] args)
        {
            
        }
    }
}
