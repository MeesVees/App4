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
    class ListViewAdapter : BaseAdapter<Auto>
    {
        private List<Auto> CarList;
        private Context Context;

        public ListViewAdapter(Context context, List<Auto> list)
        {
            this.Context = context;
            this.CarList = list;

        }

        public override int Count
        {
            get { return CarList.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Auto this[int position]
        {
            get { return CarList[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(Context).Inflate(Resource.Layout.layout1, null, false);
            }

            TextView tootja = row.FindViewById<TextView>(Resource.Id.tootja);
            TextView KW = row.FindViewById<TextView>(Resource.Id.KW);
            TextView model = row.FindViewById<TextView>(Resource.Id.model);
            ImageView carImg = row.FindViewById<ImageView>(Resource.Id.ListViewCarImg);

            KW.Text = CarList[position].kw.ToString();
            tootja.Text = CarList[position].tootja;
            model.Text = CarList[position].model;
            carImg.SetImageResource(CarList[position].imageSource);

            return row;
        }


    }
}