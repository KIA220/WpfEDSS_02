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

        public int Id_client
        {
            get { return id_client; }
            set { id_client = value; }
        }
        public string Fio_client
        {
            get { return fio_client; }
            set { fio_client = value; }
        }
        public string Tel_client
        {
            get { return tel_client; }
            set { tel_client = value; }
        }
        public Client(int id_client, string fio_client, string tel_client)
        {
            this.id_client = id_client;
            this.fio_client = fio_client;
            this.tel_client = tel_client;
        }
    }
}
