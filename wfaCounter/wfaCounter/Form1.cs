using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCounter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaultFormValues();
        }

        private void SetDefaultFormValues()
        {
            rbtCtverec.Checked = true;
            txtCtverec_Strana_a.Focus();

            txtCtverec_Strana_a.Text = "0";
            txtObdelnik_Strana_a.Text = "0";
            txtObdelnik_Strana_b.Text = "0";
            txtTrojuhelnik_Strana_a.Text = "0";
            txtTrojuhelnik_Strana_b.Text = "0";
            txtTrojuhelnik_Strana_c.Text = "0";

            Vypocet();
            rbtObdelnik.Checked = true;
            Vypocet();
            rbtTrojuhelnik.Checked = true;
            Vypocet();
            rbtCtverec.Checked = true;

        }
        private void btnVypocitat_Click(object sender, EventArgs e)
        {
            Vypocet();            
        }

        private void Vypocet()
        {
            double Strana_a = 0;
            double Strana_b= 0;
            double Strana_c = 0;

            if (rbtCtverec.Checked == true)
            {
            //ctverec
            cGeometry.Ctverec oCtverec = new cGeometry.Ctverec();
            
            Strana_a = double.Parse(txtCtverec_Strana_a.Text);

            oCtverec.Strana_a = Strana_a;
            oCtverec.SpocitejOO();

            lblObvod_Ctv.Text = oCtverec.Obvod.ToString();
            lblObsah_Ctv.Text = oCtverec.Obsah.ToString();
            }

            if (rbtObdelnik.Checked == true)
            {
            //obdelnik
            cGeometry.Obdelnik oObdelnik = new cGeometry.Obdelnik();

            Strana_a = double.Parse(txtObdelnik_Strana_a.Text);
            Strana_b = double.Parse(txtObdelnik_Strana_b.Text);

            oObdelnik.Strana_a = Strana_a;
            oObdelnik.Strana_b = Strana_b;
            oObdelnik.SpocitejOO();

            lblObvod_Obd.Text = oObdelnik.Obvod.ToString();
            lblObsah_Obd.Text = oObdelnik.Obsah.ToString();
            }

            if (rbtTrojuhelnik.Checked == true)
            {
            //trojuhelnik
            cGeometry.Trojuhelnik oTrojuhelnik = new cGeometry.Trojuhelnik();

            Strana_a = double.Parse(txtTrojuhelnik_Strana_a.Text);
            Strana_b = double.Parse(txtTrojuhelnik_Strana_b.Text);
            Strana_c = double.Parse(txtTrojuhelnik_Strana_c.Text);

            oTrojuhelnik.Strana_a = Strana_a;
            oTrojuhelnik.Strana_b = Strana_b;
            oTrojuhelnik.Strana_c = Strana_c;
            oTrojuhelnik.SpocitejOO();

            lblObvod_Troj.Text = oTrojuhelnik.Obvod.ToString();
            lblObsah_Troj.Text = oTrojuhelnik.Obsah.ToString();
            }
        }

        private void btnZavrit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZmenaUtvaru()
        {
            grpCtverec.Enabled = false;
            grpObdelnik.Enabled = false;
            grpTrojuhelnik.Enabled = false;

            if (rbtCtverec.Checked == true)
            {
                grpCtverec.Enabled = true;
            }
            if (rbtObdelnik.Checked == true)
            {
                grpObdelnik.Enabled = true;
            }
            if (rbtTrojuhelnik.Checked == true)
            {
                grpTrojuhelnik.Enabled = true;
            }

        }
        private void rbtCtverec_CheckedChanged(object sender, EventArgs e)
        {
            ZmenaUtvaru();
        }

        private void rbtObdelnik_CheckedChanged(object sender, EventArgs e)
        {
            ZmenaUtvaru();
        }

        private void rbtTrojuhelnik_CheckedChanged(object sender, EventArgs e)
        {
            ZmenaUtvaru();
        }

        private void btnVypisTXT_Click(object sender, EventArgs e)
        {
            VypisDoTXT(); 
        }

        private void VypisDoTXT()
        {
            string sFile = "";
            StreamWriter myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFile = saveFileDialog1.FileName;
                myStream = new StreamWriter(sFile);
                {
                    string sText = "";
                    sText = "Délka strany čtverce je " + txtCtverec_Strana_a.Text; 
                    myStream.WriteLine(sText);
                    sText = "Obvod čtverce je " + lblObvod_Ctv.Text;
                    myStream.WriteLine(sText);
                    sText = "Obsah čtverce je " + lblObsah_Ctv.Text;
                    myStream.WriteLine(sText);

                    sText = "Délka strany obdélníku a je " + txtObdelnik_Strana_a.Text;
                    myStream.WriteLine(sText);
                    sText = "Délka strany obdélníku b je " + txtObdelnik_Strana_b.Text;
                    myStream.WriteLine(sText);
                    sText = "Obvod obdélníku je " + lblObvod_Obd.Text;
                    myStream.WriteLine(sText);
                    sText = "Obsah obdélníku je " + lblObsah_Obd.Text;
                    myStream.WriteLine(sText);

                    sText = "Délka strany trojúhelníku a je " + txtTrojuhelnik_Strana_a.Text;
                    myStream.WriteLine(sText);
                    sText = "Délka strany trojúhelníku b je " + txtTrojuhelnik_Strana_b.Text;
                    myStream.WriteLine(sText);
                    sText = "Délka strany trojúhelníku c je " + txtTrojuhelnik_Strana_c.Text;
                    myStream.WriteLine(sText);
                    sText = "Obvod trojúhelníku je " + lblObvod_Troj.Text;
                    myStream.WriteLine(sText);
                    sText = "Obsah trojúhelníku je " + lblObsah_Troj.Text;
                    myStream.WriteLine(sText);

                    myStream.Flush();
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            UlozitData(); 
        }
        private void UlozitData()
        {
            string sFile = "";
            StreamWriter myStream;
            
            sFile = Application.StartupPath + "data.txt";
                myStream = new StreamWriter(sFile);
                {
                string sText = "";
                string sCtv_Strana_a = "";
                string sCtv_Obvod = "";
                string sCtv_Obsah = "";
                sCtv_Strana_a = txtCtverec_Strana_a.Text;
                sCtv_Obvod = lblObvod_Ctv.Text;
                sCtv_Obsah = lblObsah_Ctv.Text;

                sText = sCtv_Strana_a + ";" + sCtv_Obvod + ";" + sCtv_Obsah;
                myStream.WriteLine(sText);

                string sObd_Strana_a = "";
                string sObd_Strana_b = "";
                string sObd_Obvod = "";
                string sObd_Obsah = "";

                sObd_Strana_a = txtObdelnik_Strana_a.Text;
                sObd_Strana_b = txtObdelnik_Strana_b.Text;
                sObd_Obvod = lblObvod_Obd.Text;
                sObd_Obsah = lblObsah_Obd.Text;

                sText = sObd_Strana_a + ";" + sObd_Strana_b + ";" + sObd_Obvod + ";" + sObd_Obsah;
                myStream.WriteLine(sText);

                string sTroj_Strana_a = "";
                string sTroj_Strana_b = "";
                string sTroj_Strana_c = "";
                string sTroj_Obvod = "";
                string sTroj_Obsah = "";

                sTroj_Strana_a = txtTrojuhelnik_Strana_a.Text;
                sTroj_Strana_b = txtTrojuhelnik_Strana_b.Text;
                sTroj_Strana_c = txtTrojuhelnik_Strana_c.Text;
                sTroj_Obvod = lblObvod_Troj.Text;
                sTroj_Obsah = lblObsah_Troj.Text;

                sText = sTroj_Strana_a + ";" + sTroj_Strana_b + ";" + sTroj_Strana_c + ";" + sTroj_Obvod + ";" + sTroj_Obsah;
                myStream.WriteLine(sText);

                myStream.Flush();
                // Code to write the stream goes here.
                myStream.Close();
                
            }
        }

        private void btnNacist_Click(object sender, EventArgs e)
        {
            NacistData(); 
        }
        private void NacistData()
        {
            string sFile = "";
            string sLine = "";
            StreamReader myStream;

            sFile = Application.StartupPath + "data.txt";

            using (StreamReader sr = new StreamReader(sFile))
            {
                int iIndex = 0;
                while (sr.Peek() >= 0)
                {
                    sLine = sr.ReadLine();

                    switch(iIndex)
                    {
                       case 0:
                        string[] sData = sLine.Split(";");

                        string sCtv_Strana_a = "";
                        string sCtv_Obvod = "";
                        string sCtv_Obsah = "";

                        sCtv_Strana_a = sData[0];
                        sCtv_Obvod = sData[1];
                        sCtv_Obsah = sData[2];

                        txtCtverec_Strana_a.Text = sCtv_Strana_a;
                        lblObvod_Ctv.Text = sCtv_Obvod;
                        lblObsah_Ctv.Text = sCtv_Obsah;

                        break;
                        case 1:
                            sData = sLine.Split(";");

                            string sObd_Strana_a = "";
                            string sObd_Strana_b = "";
                            string sObd_Obvod = "";
                            string sObd_Obsah = "";


                            sObd_Strana_a = sData[0];
                            sObd_Strana_b = sData[1];
                            sObd_Obvod = sData[2];
                            sObd_Obsah = sData[3];

                            txtObdelnik_Strana_a.Text = sObd_Strana_a;
                            txtObdelnik_Strana_b.Text = sObd_Strana_b;
                            lblObvod_Obd.Text = sObd_Obvod;
                            lblObsah_Obd.Text = sObd_Obsah;
                            break;
                        case 2:
                            sData = sLine.Split(";");

                            string sTroj_Strana_a = "";
                            string sTroj_Strana_b = "";
                            string sTroj_Strana_c = "";
                            string sTroj_Obvod = "";
                            string sTroj_Obsah = "";

                            sTroj_Strana_a = sData[0];
                            sTroj_Strana_b = sData[1];
                            sTroj_Strana_c = sData[2];
                            sTroj_Obvod = sData[3];
                            sTroj_Obsah = sData[4];

                            txtTrojuhelnik_Strana_a.Text = sTroj_Strana_a;
                            txtTrojuhelnik_Strana_b.Text = sTroj_Strana_b;
                            txtTrojuhelnik_Strana_c.Text = sTroj_Strana_c;
                            lblObvod_Troj.Text = sTroj_Obvod;
                            lblObsah_Troj.Text = sTroj_Obsah;
                            break;

                    }
                    
                    iIndex++;
                }
            }

            
        }
    }
}
