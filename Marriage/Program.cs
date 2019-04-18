using System.Collections.Generic;

namespace Marriage
{
    public class Man
    {
        private string name;
        private float height;

        public bool HasEngaged { get; set; }
        public Man(string name, float height)
        {
            this.name = name;
            this.height = height;
        }

    }
    
    public class Woman
    {
        private string name;
        private float height;
        public bool HasEngaged { get; set; }


        public Woman(string name, float height)
        {
            this.name = name;
            this.height = height;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Man> men = new List<Man>();
            men.Add(new Man("Calvin",178.1f));
            men.Add(new Man("Chengyu Sun",181));
            men.Add(new Man("Xun Ruan",180));
            men.Add(new Man("Haoqian Gu",182));
            men.Add(new Man("Felix",181.5f));
            
            List<Woman> women = new List<Woman>();
            women.Add(new Woman("Meng Du",178.1f));
            women.Add(new Woman("Ella Zhang",181));
            women.Add(new Woman("Suttonz",180));
            women.Add(new Woman("Felix's gf",182));
            women.Add(new Woman("Tianfang Wang",181.5f));

            while (!IsAllMatched(men, women))
            {
                
            }

            
            
        }

        private static bool IsAllMatched(List<Man> men, List<Woman> women)
        {
            foreach (Man man in men)
            {
                if (!man.HasEngaged)
                {
                    return false;
                }
            }

            foreach (var woman in women)
            {
                if (!woman.HasEngaged)
                {
                    return false;
                }
            }

            return true;
        }
    }
}