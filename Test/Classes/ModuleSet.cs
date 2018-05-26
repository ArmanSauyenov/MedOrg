using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedOrg.Interfaces;

namespace MedOrg.Classes
{
    /*Приложение с авторизацией (включает в себя три модуля)
А) Модуль Прикрепления пациента
Б) Контролирующий модуль
В) Отчет о прикрепленных пациентах

авторизуемый пользователь, может иметь права доступа как к одному из этих модулей, так и ко всем сразу.
*/
    public class ModuleSet
    {
        public bool Zakreplenir(ref GenerateMedCenter organ, ref GeneratePatient pat, out string message)
        {
            Console.Clear();

            foreach (Patient item in pat.listPat)
            {
                item.PrintInfo();
            }
            Console.WriteLine("");
            Patient selectPatient = new Patient();
            Console.WriteLine("Select Patient ");
            int choicePatient = Int32.Parse(Console.ReadLine());
            selectPatient = pat[choicePatient];
            Console.WriteLine("");


            foreach (MedOrganization item2 in organ.listMed)
            {
                item2.PrintInfo();
            }
            Console.WriteLine("");
            MedOrganization selectMed = new MedOrganization();
            Console.WriteLine("Select Med organization ");
            int choiceMed = Int32.Parse(Console.ReadLine());
            selectMed = organ[choiceMed];
            Console.WriteLine("");

            Console.Clear();

            var t = organ.listMed.FirstOrDefault(f => f.Id == choiceMed);

            foreach (var p in t.patients)
            {
                if (p.ID == choicePatient)
                {
                    message = "This patient is already attached!";
                    return false;
                }
            }

            t.patients.Add(selectPatient);
            pat.listPat.FirstOrDefault(f => f.ID == choicePatient)
                .MedOrgan = selectMed;

            message = "The patient is successfully attached!";
            return true;
        }

    }

}

