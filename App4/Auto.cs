using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App4
{
    public class Auto
    {
        public int kw { get; set; }
        public string tootja { get; set; }
        public int imageSource { get; set; }
        public string model { get; set; }
        public Auto(int kw, string tootja, string model, int image)
        {
            this.kw = kw;
            this.tootja = tootja;
            this.imageSource = image;
            this.model = model;
        }
    }
}