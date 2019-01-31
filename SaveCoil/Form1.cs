using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveCoil
{
    public partial class BarcodeCapture : Form
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        int i = 1; // total number of records

        public BarcodeCapture()
        {
            InitializeComponent();
            i = 1;
            // display all coils scanned today

            if ((System.IO.File.Exists(@"C:\SavedCoils\" + date + ".csv")) == true)
            {
                int j = 1; // sequence number
                TodayCoil.Text = "Today's Coil \n";
                foreach (string line in System.IO.File.ReadLines(@"C:\SavedCoils\" + date + ".csv"))
                {
                    TodayCoil.Text = TodayCoil.Text + j + ". " + line + "\n";
                    j++;
                    i++;
                    if (i > 15)
                    {
                        break;
                    }
                }

                int k = 1; // use to skip the first 12 lines
                TodayCoil2.Text = "";
                foreach (string line in System.IO.File.ReadLines(@"C:\SavedCoils\" + date + ".csv"))
                {
                    if (k > 15)
                    {
                        TodayCoil2.Text = TodayCoil2.Text + j + ". " + line + "\n";
                        j++;
                        i++;
                    }
                    k++;
                }
            }
        }

        private async void Barcode_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(500);
            string path = @"C:\SavedCoils\" + date + ".csv";
            string coilID = Barcode.Text;
            if (coilID != "")
            {
                coilID = coilID.Replace('+', ',');
                string dt = DateTime.Now.ToString("HH:mm:ss");
                coilID = coilID + ", " + dt;
                TextWriter txt = new StreamWriter(path, true); // true means text will be appended to the file.
                txt.WriteLine(coilID);
                txt.Close();
                Message.Text = "CoilID " + coilID.Substring(0, 9) + " saved!";
                Barcode.Text = "";

                // display all coils scanned today
                if ((System.IO.File.Exists(@"C:\SavedCoils\" + date + ".csv")) == true)
                {
                    if (i <= 15)
                    {
                        int j = 1; // sequence number
                        TodayCoil.Text = "Today's Coil \n";
                        foreach (string line in System.IO.File.ReadLines(@"C:\SavedCoils\" + date + ".csv"))
                        {
                            TodayCoil.Text = TodayCoil.Text + j + ". " + line + "\n";
                            j++;
                        }
                        i++;
                    }
                    else
                    {
                        int j = 16; // sequence number
                        int k = 1; // use to skip the first 12 lines
                        TodayCoil2.Text = "";
                        foreach (string line in System.IO.File.ReadLines(@"C:\SavedCoils\" + date + ".csv"))
                        {
                            if (k > 15)
                            {
                                TodayCoil2.Text = TodayCoil2.Text + j + ". " + line + "\n";
                                j++;
                            }
                            k++;
                        }
                        i++;
                    }
                }
            }
        }
    }
}
