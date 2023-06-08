
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
        public int user_role { get; set; }   

        public User() { }

     
        public User(string id_jobtitle, string fio_user) 
        { 
            this.id_jobtitle = id_jobtitle;
            this.fio_user = fio_user;
        }
        public User(int id_user, string id_jobtitle, string fio_user, string tel_user, int user_role)
        {
            this.id_user = id_user;
            this.id_jobtitle = id_jobtitle;
            this.fio_user = fio_user;
            this.tel_user = tel_user;
            this.user_role = user_role;
        }

    }
}
