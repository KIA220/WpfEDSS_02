using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEDSS.Classes
{
    //Класс модель процесс
    public class Process
    {
        [Key]
        public int id_process { get; set; }
        public string id_comment { get; set; }
        public int id_qr_code { get; set; }
        public string id_user { get; set; }
        public int id_report { get; set; }
        public string id_client { get; set; }

        public Process() { }

        public Process(int id_process, string id_comment, int id_qr_code, string id_user, int id_report, string id_client)
        {
            this.id_process = id_process;
            this.id_comment = id_comment;
            this.id_qr_code = id_qr_code;
            this.id_user = id_user;
            this.id_report = id_report;
            this.id_client = id_client;
        }

    }
}
