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
    public partial class SaveCoil : Form
    {
        public SaveCoil()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string path = @"C:\" + date + ".csv";
            FileName.Text = path;
            string coilID = Barcode.Text;
            coilID = coilID.Replace('+', ',');
            string dt = DateTime.Now.ToString("HH:mm:ss");
            coilID = coilID + ", " + dt;
            TextWriter txt = new StreamWriter(path, true); // true means text will be appended to the file.
            txt.WriteLine(coilID);
            txt.Close();
            Message.Text = "CoilID " + coilID.Substring(0, 9) + " saved!";
        }
    }
}
