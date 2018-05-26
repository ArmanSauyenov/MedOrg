using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MedOrg.Classes
{
    /*4.	Запросы на прикрепление (Дата создания, Дата обработки, Пациент, статус запроса)*/
    public class AttachmentRequests 
    {
        public DateTime DateOfApplication { get; set; }
        public DateTime DateOfProcessing { get; set; }
        public string Status { get; set; }
        public string Patient { get; set; }
        public string MedOrganiz { get; set; }
    }
}
