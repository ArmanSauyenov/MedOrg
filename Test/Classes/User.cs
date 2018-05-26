using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    public class User : MedOrganization
    {
        /*3.	Пользователи (Логин, Пароль, Права доступа, Мед организация)*/
        public string Login { get; set; }
        public string Password { get; set; }
        public int AccessRights { get; set; }
        public string MedOrganization { get; set; }

    }
}
