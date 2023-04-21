using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManajemenArtis_Lib
{
    public enum jabatan
    {
        manager,
        superAdmin
    }

    public class Manager
    {      
        #region data member
        private int id;
        private string nama;
        private DateTime tglLahir;
        private DateTime tglMasuk;
        private string username;
        private string password;
        private jabatan title;
        #endregion

        #region construct
        public Manager()
        {
            this.Id = 0;
            this.Nama = "";
            this.TglLahir = DateTime.Now;
            this.TglMasuk = DateTime.Now;
            this.Username = "";
            this.Password = "";
        }
        public Manager(int id, string nama, DateTime tglLahir, DateTime tglMasuk, string username, string password, jabatan title)
        {
            this.Id = id;
            this.Nama = nama;
            this.TglLahir = tglLahir;
            this.TglMasuk = tglMasuk;
            this.Username = username;
            this.Password = password;
            this.Title = title;
        }
        #endregion

        #region props
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public DateTime TglMasuk { get => tglMasuk; set => tglMasuk = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public jabatan Title { get => title; set => title = value; }
        #endregion

        #region methods
        public static Manager CekLogin(string username, string password)
        {
            //Password tidak diambil karena tidak perlu menyimpan password pada obyek manajer untuk alasan keamanan
            string sql = "SELECT id, nama, tanggal_lahir, tanggal_masuk, username, jabatan " +
                    "FROM manajer " +
                    "WHERE username='" + username + "' AND password='" + password + "';";

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            Manager tmp = new Manager();
            if (result.Read())
            {                
                tmp = new Manager(
                    result.GetInt32("id"),
                    result.GetString("nama"),
                    result.GetDateTime("tanggal_lahir"),
                    result.GetDateTime("tanggal_masuk"),
                    result.GetString("username"),
                    "",
                    (result.GetString("jabatan") == "manager" ? jabatan.manager : jabatan.superAdmin));
            }
            return tmp;
        }
        
        public static List<Manager> BacaData(string criteriaName, string criteriaValue)
        {
            string sql = "SELECT id, nama, tanggal_lahir, tanggal_masuk, username, jabatan  " +
               " FROM manajer ";
            if (criteriaName == "")
            {
                sql += ";";
            }
            else
            {
                sql += " WHERE " + criteriaName + " LIKE '%" + criteriaValue + "%';";
            }

            MySqlDataReader result = Koneksi.JalankanQuery(sql);
            List<Manager> tmpList = new List<Manager>();
            Manager tmp = new Manager();
            while (result.Read())
            {
                tmp = new Manager(
                    result.GetInt32("id"),
                    result.GetString("nama"),
                    result.GetDateTime("tanggal_lahir"),
                    result.GetDateTime("tanggal_masuk"),
                    result.GetString("username"),
                    "",
                    (result.GetString("jabatan") == "manager" ? jabatan.manager : jabatan.superAdmin));

                tmpList.Add(tmp);
            }
            return tmpList;
        }

        #endregion

    }
}
