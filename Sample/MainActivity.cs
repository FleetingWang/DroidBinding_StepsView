using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Linq;
using DroidStepsView;
using Android.Support.V4.Content;

namespace Binding_StepsView_Sample
{
    [Activity(
        Label = "@string/app_name", 
        MainLauncher = true, 
        Icon = "@mipmap/ic_launcher",
        Theme = "@style/AppTheme",
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        private string[] views = {"View 1", "View 2", "View 3", "View 4", "View 5", "View 6",
            "View 7", "View 8", "View 9", "View 10", "View 11", "View 12"};
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ListView mListView = FindViewById<ListView>(Resource.Id.list);
            
            MyAdapter adapter = new MyAdapter(this, 0);
            adapter.AddAll(views.ToList());
            mListView.Adapter = adapter;
        }

        private class MyAdapter : ArrayAdapter<string>
        {
            string[] labels = { "Step 1", "Step 2", "Step 3", "Step 4", "Step 5" };
            int[] colors = { Resource.Color.red, Resource.Color.blue, Resource.Color.orange };
            Activity context;
            public MyAdapter(Activity context, int resource)
                : base(context, resource)
            {
                this.context = context;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                View view = convertView; // re-use an existing view, if one is available
                if (view == null) // otherwise create a new one
                    view = context.LayoutInflater.Inflate(Resource.Layout.row, null);

                view.FindViewById<TextView>(Resource.Id.label).Text = GetItem(position);
                var color = colors[position % colors.Length];
                view.FindViewById<StepsView>(Resource.Id.stepsView)
                    .SetCompletedPosition(position % labels.Length)
                    .SetLabels(labels)
                    .SetBarColorIndicator(ContextCompat.GetColor(context, Resource.Color.material_blue_grey_800))
                    .SetProgressColorIndicator(ContextCompat.GetColor(context, color))
                    .SetLabelColorIndicator(ContextCompat.GetColor(context, color))
                    .DrawView();

                return view;
            }
        }
    }
}

