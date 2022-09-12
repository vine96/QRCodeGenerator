using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator.Forms
{
    public partial class FrmQRCodeURL : Form
    {
        private Image _imgQRCode;
        private string _format;
        public FrmQRCodeURL()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            _format = string.Empty;
            _imgQRCode = null;
            txtURL.Clear();
            picImage.BackgroundImage = null;
            oUcQRConfig.setDefaultOptions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveImage.Save(_imgQRCode, _format);
        }

        private void FrmQRCodeURL_Load(object sender, EventArgs e)
        {
            btnClean_Click(btnClean, new EventArgs());
        }
    }
}
