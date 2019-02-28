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
        string time = DateTime.Now.ToString("HH:mm:ss");
        int i = 1; // total number of records

        public BarcodeCapture()
        {
            InitializeComponent();
            i = 1;
            // display all coils scanned today
            displayContent();
        }

        private async void Barcode_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(500);

            string path = @"C:\CapturedCoils\" + date + ".csv";
            string coilID = Barcode.Text;
            if (coilID != "")
            {

                coilID = coilID.Replace('+', ',');
                date = DateTime.Now.ToString("yyyy-MM-dd");
                time = DateTime.Now.ToString("HH:mm:ss");
                string dt = date + " " + time;
                coilID = coilID + ",    " + dt;
                TextWriter txt = new StreamWriter(path, true); // true means text will be appended to the file.
                txt.WriteLine(coilID);
                txt.Close();
                string[] barcodeArr = coilID.Split(',');

                Barcode.Text = "";

                // display all coils scanned today
                updateContent();
            }
        }

        // call this function whenever we open the application
        private void displayContent()
        {
            if ((System.IO.File.Exists(@"C:\CapturedCoils\" + date + ".csv")) == true)
            {
                int j = 1; // sequence number
                ItemScanned.Text = "Item scanned: \n";
                foreach (string line in System.IO.File.ReadLines(@"C:\CapturedCoils\" + date + ".csv"))
                {
                    ItemScanned.Text = ItemScanned.Text + j + ". " + line + "\n";
                    j++;
                    i++;
                    if (i > 15)
                    {
                        break;
                    }
                }

                int k = 1; // use to skip the lines displayed by TodayCoil so they don't duplicate.
                TodayCoil2.Text = "";
                foreach (string line in System.IO.File.ReadLines(@"C:\CapturedCoils\" + date + ".csv"))
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

        // call this function whenever we scan the barcode
        private void updateContent()
        {
            if ((System.IO.File.Exists(@"C:\CapturedCoils\" + date + ".csv")) == true)
            {
                if (i <= 15)
                {
                    int j = 1; // sequence number
                    ItemScanned.Text = "Item scanned: \n";
                    foreach (string line in System.IO.File.ReadLines(@"C:\CapturedCoils\" + date + ".csv"))
                    {
                        ItemScanned.Text = ItemScanned.Text + j + ". " + line + "\n";
                        j++;
                    }
                    i++;
                }
                else
                {
                    int j = 16; // sequence number
                    int k = 1; // use to skip the lines displayed by TodayCoil so they don't duplicate.
                    TodayCoil2.Text = "";
                    foreach (string line in System.IO.File.ReadLines(@"C:\CapturedCoils\" + date + ".csv"))
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
