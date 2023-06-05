﻿
using System.ComponentModel.DataAnnotations;

namespace WpfEDSS.Classes
{
    //класс модель Пользователь
    public class User
    {
        [Key]
        public int id_user { get; set; }
        public string id_jobtitle { get; set; }
        public string fio_user { get; set; }
        public string tel_user { get; set; }

        public User() { }

        public string Id_jobtitle
        {
            get { return id_jobtitle; }
            set { id_jobtitle = value; }
        }
        public string Fio_user
        {
            get { return fio_user; }
            set { fio_user = value; }
        }

        public User(string id_jobtitle, string fio_user) 
        { 
            this.id_jobtitle = id_jobtitle;
            this.fio_user = fio_user;
        }
        public User(int id_user, string id_jobtitle, string fio_user, string tel_user)
        {
            this.id_user = id_user;
            this.id_jobtitle = id_jobtitle;
            this.fio_user = fio_user;
            this.tel_user = tel_user;
        }

    }
}
