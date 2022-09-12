﻿namespace Entities.Settings
{
    public class QRConfig
    {
        public string Size { get; set; }
        public string CharsetSource { get; set; }
        public string CharsetTarget { get; set; }
        public char ECC { get; set; }
        public string Color { get; set; }
        public string BGColor { get; set; }
        public int Margin { get; set; }
        public int QZone { get; set; }
        public string Format { get; set; }
    }
}
