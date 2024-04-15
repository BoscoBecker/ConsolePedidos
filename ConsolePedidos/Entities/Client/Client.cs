using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePedidos.Entities.Clients
{
    class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthday { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthday)
        {
            this.name = name;
            this.email = email;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            StringBuilder sbClient = new StringBuilder();
            sbClient.AppendLine(name);
            sbClient.AppendLine(email);
            sbClient.AppendLine(birthday.ToString());
            return sbClient.ToString();
                
        }
    }
}
