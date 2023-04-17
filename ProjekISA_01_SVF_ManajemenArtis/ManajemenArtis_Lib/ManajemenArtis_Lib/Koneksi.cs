using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace ManajemenArtis_Lib
{
    public class Koneksi
    {
        private MySqlConnection koneksiDb;

        public MySqlConnection KoneksiDb { get => koneksiDb; private set => koneksiDb = value; }

        public Koneksi(string pServer, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "server=" + pServer + ";database=" + pDatabase + ";uid=" + pUsername + ";password=" + pPassword;
            KoneksiDb = new MySqlConnection();

            KoneksiDb.ConnectionString = strCon;

            Connect();
        }

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections["ProjekISA_01_SVF_ManajemenArtis.db"] as ClientSettingsSection;

            string DbServer = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword;
            KoneksiDb = new MySqlConnection();

            KoneksiDb.ConnectionString = strCon;

            Connect();
        }

        public void Connect()
        {
            if (KoneksiDb.State == System.Data.ConnectionState.Open)
            {
                KoneksiDb.Close();

            }
            KoneksiDb.Open();
        }

        public static MySqlDataReader AmbilData(string sql)
        {
            Koneksi koneksi = new Koneksi();
            MySqlCommand command = new MySqlCommand(sql, koneksi.koneksiDb);
            MySqlDataReader hasil = command.ExecuteReader();
            return hasil;
        }

        public static int JalankanPerintahDML(string sql)
        {
            Koneksi koneksi = new Koneksi();
            MySqlCommand command = new MySqlCommand(sql, koneksi.koneksiDb);
            return command.ExecuteNonQuery();
        }
    }
}
