﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public static class SaveImage
    {
        public static void Save(Image imgQRCode, string format)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            if (format.Equals("png"))
            {
                sfDialog.Filter = "PNG Image | *.png";
            }
            else if (format.Equals("gif"))
            {
                sfDialog.Filter = "GIF Image | *.gif";
            }
            else if (format.Equals("jpeg"))
            {
                sfDialog.Filter = "JPEG Image | *.jpeg";
            }
            else
            {
                sfDialog.Filter = "JPG Image | *.jpg";
            }

            sfDialog.Title = "Salvar QRCode";
            sfDialog.FileName = "QRCode";
            sfDialog.InitialDirectory = @"C:\Users\vinic\Pictures\QRCodes";

            sfDialog.ShowDialog();
        }
    }
}
