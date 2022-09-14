using Entities.Settings;
using GoQRCode.Net;
using System;
using System.Drawing;
using System.Net;
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
            if (txtURL.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Atenção\n\nVocê precisa informar uma URL.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!txtURL.Text.Trim().Contains("http://") && !txtURL.Text.Trim().Contains("https://"))
            {
                MessageBox.Show("Atenção\n\nDigite uma URL válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QRConfig config = oUcQRConfig.GetConfig();
            string strData = WebUtility.UrlEncode(txtURL.Text.Trim());
            _format = config.Format;
            _imgQRCode = new GoQRCode.Net.GoQRCode().GetQRCode(strData, config);
            if (_imgQRCode != null)
            {
                picImage.BackgroundImage = _imgQRCode;
                picImage.BackgroundImageLayout = ImageLayout.Stretch;
                btnSave.Enabled = true;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
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

        private void oUcQRConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
