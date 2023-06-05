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
        public int id_comment { get; set; }
        public int id_qr_code { get; set; }
        public int id_user { get; set; }
        public int id_report { get; set; }
        public int id_client { get; set; }

        public Process() { }

        public int Id_process
        {
            get { return id_process; }
            set { id_process = value; }
        }
        public int Id_comment
        {
            get { return id_comment; }
            set { id_comment = value; }
        }
        public int Id_qr_code
        {
            get { return id_qr_code; }
            set { id_qr_code = value; }
        }
        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }
        public int Id_report
        {
            get { return id_report; }
            set { id_report = value; }
        }
        public int Id_client
        {
            get { return id_client; }
            set { id_client = value; }
        }


        public Process(int id_process, int id_comment, int id_qr_code, int id_user, int id_report, int id_client)
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
