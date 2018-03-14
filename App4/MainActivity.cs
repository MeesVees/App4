using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App4
{
    [Activity(Label = "App4", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private ListView carListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            carListView = FindViewById<ListView>(Resource.Id.listView1);

            List<Auto> autoList = new List<Auto>();

           /* autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.audir82017));
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.bmw325e30));
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.chrysler300));
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.kiaceed34));
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.lada900));
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.masda));*/
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.maseratidiisel));
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.lada110));
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.merkedes));
            autoList.Add(new Auto(350, "2017 aasta auto", "MI385", Resource.Drawable.suzukiswifthatcback));
            ListViewAdapter viewAdap = new ListViewAdapter(this, autoList);

            carListView.Adapter = viewAdap;
        }
    }
}

