using System;
using System.Collections.Generic;
using System.IO;

namespace ARAF
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> champs = new List<string>(){ };

            using (StreamReader file = new StreamReader(@"C:\_\lolchamps.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    champs.Add(ln);
                }
                file.Close();
            }

            Random r = new Random();

            List<string> selected = new List<string>() { };

            while (selected.Count < 5)
            {

                var index = r.Next(champs.Count);
                var champ = champs[index];

                if (!selected.Contains(champ))
                {
                    selected.Add(champ);
                }

            }

            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("GL HF WITH ARAF");
            Console.WriteLine("");
        }
    }
}
