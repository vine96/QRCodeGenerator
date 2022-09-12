using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class ucQRConfig : UserControl
    {
        public ucQRConfig()
        {
            InitializeComponent();
        }

        private void ucQRConfig_Load(object sender, EventArgs e)
        {
            if(this.DesignMode) return;

            //size
            cmbSize.Items.Clear();
            for(int i = 1; i <= 10; i++)
            {
                cmbSize.Items.Add(string.Format("{0}x{0}", i*100));
            }

            //charset-source
            cmbCharsetSource.Items.Clear();
            cmbCharsetSource.Items.Add("ISO-8859-1");
            cmbCharsetSource.Items.Add("UTF-8");

            //charset-target
            cmbCharsetTarget.Items.Clear();
            cmbCharsetTarget.Items.Add("ISO-8859-1");
            cmbCharsetTarget.Items.Add("UTF-8");

            //ECC
            cmbECC.Items.Clear();
            string[] values = { 
                "L (low, ~7% destroyed data may be corrected)", 
                "M (middle, ~15% destroyed data may be corrected)",
                "Q (quality, ~25% destroyed data may be corrected)",
                "H (high, ~30% destroyed data may be corrected)"
            };

            foreach (var item in values)
            {
                cmbSize.Items.Add(item);
            }

            //Color
            cmbColor.Items.Clear();
            cmbColor.Items.Add("000000"); //preto
            cmbColor.Items.Add("FFFFFF"); //branco
            cmbColor.Items.Add("FF0000"); //vermelho
            cmbColor.Items.Add("00FF00"); //verde
            cmbColor.Items.Add("0000FF"); //azul

            //BG-Color
            cmbBGColor.Items.Clear();
            cmbBGColor.Items.Add("000000"); //preto
            cmbBGColor.Items.Add("FFFFFF"); //branco
            cmbBGColor.Items.Add("FF0000"); //vermelho
            cmbBGColor.Items.Add("00FF00"); //verde
            cmbBGColor.Items.Add("0000FF"); //azul

            //Margin
            cmbMargin.Items.Clear();
            for (int i = 0; i <= 50; i++)
            {
                cmbMargin.Items.Add(i);
            }

            //QZone
            cmbQZone.Items.Clear();
            for (int i = 0; i <= 100; i++)
            {
                cmbQZone.Items.Add(i);
            }

            //Format
            cmbFormat.Items.Clear();
            string[] formats = {
                "png", "gif", "jpeg", "jpg"
            };

            foreach (var item in formats)
            {
                cmbFormat.Items.Add(item);
            }

            setDefaultOptions();

        }

        public void setDefaultOptions()
        {
            cmbSize.SelectedIndex = 1;
            cmbCharsetSource.SelectedIndex = 1;
            cmbCharsetTarget.SelectedIndex = 1;
            cmbECC.SelectedIndex = 0;
            cmbColor.SelectedIndex = 0;
            cmbBGColor.SelectedIndex = 1;
            cmbMargin.SelectedIndex = 1;
            cmbQZone.SelectedIndex = 0;
            cmbFormat.SelectedIndex = 0;

        }

        private void cmbCharsetSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
