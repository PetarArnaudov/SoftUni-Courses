using System;

namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int docs = 7;

            int treatedPatients = 0, untreatedPatients = 0;


            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > treatedPatients) 
                {
                    docs++;
                }

                if (patients >= docs)
                {
                    treatedPatients += docs;
                    untreatedPatients += patients - docs;
                }
                else
                {
                    treatedPatients += patients;
                }

            }


            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
