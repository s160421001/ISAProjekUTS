using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ManajemenArtis_Lib
{
    class Kontrak_kerja
    {
        public enum status_artis
        {
            terima,
            tolak
        }

        #region data member
        private int id;
        private string nama;
        private string deskripsi;
        private DateTime tblBuat;
        private DateTime tglAcara;
        private status_artis status;
        private Manager manager;
        private Artis artis;
        #endregion

        #region construct
        public Kontrak_kerja(int id, string nama, string deskripsi, DateTime tblBuat, DateTime tglAcara, status_artis status, Manager manager, Artis artis)
        {
            this.Id = id;
            this.Nama = nama;
            this.Deskripsi = deskripsi;
            this.TblBuat = tblBuat;
            this.TglAcara = tglAcara;
            this.Status = status;
            this.Manager = manager;
            this.Artis = artis;
        }
        #endregion

        #region props
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public DateTime TblBuat { get => tblBuat; set => tblBuat = value; }
        public DateTime TglAcara { get => tglAcara; set => tglAcara = value; }
        internal status_artis Status { get => status; set => status = value; }
        public Manager Manager { get => manager; set => manager = value; }
        public Artis Artis { get => artis; set => artis = value; }
        #endregion

        #region METHODS        
        public static List<Kontrak_kerja> BacaData(string criteriaName, string criteriaValue)
        {
            string sql = "SELECT k.id, k.nama, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status,  " +
               " FROM kontrak_kerja k " +
               " INNER JOIN artis a ON a.id=k.artis_id " +
               " INNER JOIN manajer m ON m.id=k.manajer_id ";

            if (criteriaName == "")
            {
                sql += ";";
            }
            else
            {
                sql += " AND " + criteriaName + " LIKE '%" + criteriaValue + "%';";
            }

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            List<Kontrak_kerja> tmpList = new List<Kontrak_kerja>();

            while (result.Read())
            {
                Artis tmpArtis = new Artis();
                tmpArtis.Id = result.GetInt32("artis_id");
                tmpArtis.Nama = result.GetString("nama");

                Manager tmpMan = new Manager();
                tmpMan.Id = result.GetInt32("manajer_id");
                tmpMan.Nama = result.GetString("nama");

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("nama"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    (result.GetString("status") == "terima" ? status_artis.terima : status_artis.tolak),
                    tmpMan, tmpArtis
                    );

                tmpList.Add(tmp);
            }

            return tmpList;
        }
        #endregion
    }
}
