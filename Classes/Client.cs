using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEDSS.Classes
{
    public class Client
    {
        [Key]
        public int id_client { get; set; }
        public string fio_client { get; set; }
        public string tel_client { get; set; }

        public Client() { }

        
        public Client(int id_client, string fio_client, string tel_client)
        {
            this.id_client = id_client;
            this.fio_client = fio_client;
            this.tel_client = tel_client;
        }
    }
}
