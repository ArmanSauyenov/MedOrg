using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Classes;
using Test.Interfaces;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratePatient gener = new GeneratePatient();
            gener.GenetatePatient(10);

            GenerateMedCenter medc = new GenerateMedCenter();
            medc.GenetateMed();

            ModuleSet moduleSet = new ModuleSet();
            string message = "";

            while (true)
            {
                Console.WriteLine("--------------------Menu---------------------");
                Console.WriteLine("For show all patients press 1");
                Console.WriteLine("For show all Med organizations press 2");
                Console.WriteLine("For attach the patient, press 3 ");
                Console.WriteLine("For exit press 0");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:  gener.SearchPatient(); break;
                    case 2:  medc.SearchMedOrg(); break;
                    case 3:  moduleSet.Zakreplenir(ref medc, ref gener, out message); break;
                    case 0: return;

                }
            }

        }
    }
}
