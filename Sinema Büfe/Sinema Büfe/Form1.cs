using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasapara = 0;
        int koltuksayisi = 200;
        int koladepo = 70;
        int misirdepo = 80;
        int sudepo = 150;
        int departisu, departikola, departimısır;

        private void button3_Click(object sender, EventArgs e)
        {
            koltuksayisi = 200;
            kasapara = kasapara - 1000;
            KasaLabel.Text = kasapara.ToString() + " TL";
            Koltuksayi.Text = koltuksayisi.ToString();
            sudepo = sudepo + departisu;
            departisu = 0;
            koladepo = koladepo + departikola;
            departikola = 0;
            misirdepo = misirdepo + departimısır;
            departimısır = 0;
            KolaDepos.Text = koladepo.ToString();
            suDepos.Text = sudepo.ToString();
            Misirdepos.Text = misirdepo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int misiradet, suadet, kolaadet, biletadet, toplamfiyat;
            misiradet = Convert.ToInt16(TxtMisir.Text);
            if (misiradet > misirdepo)
            {
                MessageBox.Show("Elimizde yeterince mısır bulunmamaktadır, lütfen satın alınız");
                misiradet = 0;
            }
            else
            {
                misirdepo = misirdepo - misiradet;
            }
            suadet = Convert.ToInt16(TxTSu.Text);
            if (suadet> sudepo)
            {
                MessageBox.Show("Elimizde yeterince su bulunmamaktadır, lütfen satın alınız");
                suadet = 0;
            }
            else
            {
                sudepo = sudepo - suadet;
            }
            kolaadet = Convert.ToInt16(TxTKola.Text);
            if (kolaadet > koladepo)
            {
                MessageBox.Show("Elimizde yeterince kola bulunmamaktadır, lütfen satın alınız");
                kolaadet = 0;
            }
            else
            {
                koladepo = koladepo - kolaadet;
            }
            biletadet = Convert.ToInt16(TxTBilet.Text);
            if (biletadet > koltuksayisi)
            {
                MessageBox.Show("Elimizde yeterince bilet bulunmamaktadır");
                biletadet = 0;
            }
            else {
                koltuksayisi = koltuksayisi - biletadet;
            }
            TxtMisir.Text = "";
            TxTSu.Text = "";
            TxTKola.Text = "";
            TxTBilet.Text = "";

            toplamfiyat = misiradet * 9 + suadet * 2 + kolaadet * 7 + biletadet * 19;
            FiyatLabel.Text = toplamfiyat.ToString() + " TL";
            kasapara = kasapara + toplamfiyat;
            KasaLabel.Text = kasapara.ToString() + " TL";
            Koltuksayi.Text = koltuksayisi.ToString();
            KolaDepos.Text = koladepo.ToString();
            suDepos.Text = sudepo.ToString();
            Misirdepos.Text = misirdepo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            departisu = Convert.ToInt16(DPsu.Text);
            departikola = Convert.ToInt16(DpKola.Text);
            departimısır = Convert.ToInt16(DpMısır.Text);
            kasapara = kasapara - (departisu * 1 + departikola * 4 + departimısır * 6);
            DPsu.Text = "";
            DpKola.Text = "";
            DpMısır.Text = "";
            KasaLabel.Text = kasapara.ToString() + " TL";
        }
    }
}
