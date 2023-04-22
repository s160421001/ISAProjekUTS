using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; 
using System.Drawing; 
using System.Drawing.Printing;

namespace ManajemenArtis_Lib
{
    class Print
    {
        #region data member
        private Font fontType;
        private StreamReader fileName; 
        private float marginKanan, marginKiri, marginAtas, marginBawah;
        #endregion

        #region construct
        public Print(Font fontType, string fileName, float marginKanan, float marginKiri, float marginAtas, float marginBawah)
        {
            this.FontType = fontType;
            this.FileName = new StreamReader(fileName);
            this.MarginKanan = marginKanan;
            this.MarginKiri = marginKiri;
            this.MarginAtas = marginAtas;
            this.MarginBawah = marginBawah;
        }
        #endregion

        #region props
        public Font FontType { get => fontType; set => fontType = value; }
        public StreamReader FileName { get => fileName; set => fileName = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        #endregion

        #region METHODS
        private void Cetak(object sender, PrintPageEventArgs e)
        {
            int maxBaris = (int)((e.MarginBounds.Height - MarginAtas - MarginBawah) / FontType.GetHeight(e.Graphics));
            float Y = MarginAtas;
            float X = MarginKiri;
            int jumBaris = 0; 

            string teksTulis = FileName.ReadLine();

            while (jumBaris < maxBaris && teksTulis != null)
            {
                Y = MarginAtas + (jumBaris * FontType.GetHeight(e.Graphics));
                e.Graphics.DrawString(teksTulis, FontType, Brushes.BlueViolet, X, Y);
                teksTulis = FileName.ReadLine();
                jumBaris++;
            }

            if (teksTulis == null)
                e.HasMorePages = false;
            else
                e.HasMorePages = true; 
        }
        public void SendToPrinter()
        {
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            p.PrintPage += new PrintPageEventHandler(Cetak);
            p.Print();

            FileName.Close();
        }
        #endregion
    }
}
