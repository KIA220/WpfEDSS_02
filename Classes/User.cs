
namespace WpfEDSS.Classes
{
    //класс модель Пользователь
    internal class User
    {
        public int id { get; set; }
        public string id_jobtitle { get; set; }
        public string FIO { get; set; }
        public string tel { get; set; }

        public User() { }

        public string Id_jobtitle
        {
            get { return id_jobtitle; }
            set { id_jobtitle = value; }
        }
        public string Fio
        {
            get { return FIO; }
            set { FIO = value; }
        }

        public User(string id_jobtitle, string FIO) 
        { 
            this.id_jobtitle = id_jobtitle;
            this.FIO = FIO;
        }

    }
}
