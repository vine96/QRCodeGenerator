﻿using Entities.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Drawing;
using Image = System.Drawing.Image;

namespace GoQRCode.Net
{
    public class GoQRCode
    {
        public Image GetQRCode(string data, QRConfig config)
        {
            Image imgQRCode = null;
            string URLGoQR = "http://api.qrserver.com/v1/create-qr-code/?data={0}&size={1}&charset-source={2}&charset-target{3}&ecc={4}&color={5}&bgcolor={6}&margin={7}&qzone={8}&format={9}";

            string strData = string.Format(URLGoQR,
                                            data,
                                            config.Size,
                                            config.CharsetSource,
                                            config.CharsetTarget,
                                            config.ECC,
                                            config.Color,
                                            config.BGColor,
                                            config.Margin,
                                            config.QZone,
                                            config.Format
                                            );

            WebRequest request = WebRequest.Create(strData);

            using (WebResponse response = request.GetResponse())
            {
                Stream st = response.GetResponseStream();
                imgQRCode = Bitmap.FromStream(st);
            }

            return imgQRCode;
        }
    }
}
