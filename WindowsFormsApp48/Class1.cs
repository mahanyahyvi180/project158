using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp48
{
    namespace teacher
    {
        public class cEmployee
        {
            public string identity;
            public string firstname;
            public string lastname;

            public cEmployee()
            {
                firstname = "ali";
                lastname = "razavi";
            }

            public string Concatinate()
            {
                return firstname + ' ' + lastname;
            }
        }
    }
}
