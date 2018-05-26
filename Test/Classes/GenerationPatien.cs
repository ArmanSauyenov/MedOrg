using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedOrg.Interfaces;

namespace MedOrg.Classes
{
    public class GeneratePatient
    {

        private Random rand = new Random();
        public List<Patient> listPat;
        Generator gen = new Generator();

        public Patient this[int iin]
        {
            get
            {
                foreach (Patient item in listPat)
                {
                    if (item.ID == iin)
                        return item;
                }
                return null;
            }
        }

        public GeneratePatient()
        {
            listPat = new List<Patient>();
        }

        public void GenetatePatient(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Patient patient = new Patient();
                patient.Name = gen.GenerateDefault(Gender.man);
                patient.ID = rand.Next(600000, 999999);
                listPat.Add(patient);
            }
        }

        public void PrintPatient()
        {
            foreach (Patient item in listPat)
            {
                item.PrintInfo();
                Console.WriteLine("----------------------------------");
            }

        }

        public Patient SearchPatient()
        {
            Console.Clear();
            PrintPatient();
            Console.WriteLine("Enter pation's name ");
            string name = Console.ReadLine();
            Console.WriteLine();

            foreach (Patient pation in listPat)
            {
                if (pation.Name.Contains(name))
                {
                    Console.WriteLine("Найденный пациент:");
                    pation.PrintInfo();
                    return pation;
                }
            }
            return null;
        }
    }
}
