using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedOrg.Classes;

namespace MedOrg.Interfaces
{
    /*1.	Пациент (Фамилия, Имя, Отчество, ИИН)*/
    public class Patient
    {
        public MedOrganization MedOrgan { get; set; }
        private string Name_;
        public string Name
        {
            get
            {
                return Name_;
            }
            set
            {
                Name_ = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", "");
            }
        }
        public int ID { get; set; }


        public void PrintInfo()
        {
            Console.WriteLine("Name - " + Name);
            Console.WriteLine("ID - " + ID);
            Console.WriteLine();
            
        }
    }
}
