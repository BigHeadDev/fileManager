using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fileManager
{
    public partial class FormTxtReader : Form
    {
        string path = "";
        public FormTxtReader(string path)
        {
            this.path = path;
            InitializeComponent();
            InitTxt();
        }
        public void InitTxt()
        {
            string txtAll = File.ReadAllText(path,Encoding.Default);
            txtReader.Text = txtAll;
        }
        private void btnTxtSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path,txtReader.Text,Encoding.Default);
            MessageBox.Show("保存成功！","提示");
            this.Close();
        }
    }
}
