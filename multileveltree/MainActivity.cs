using Android.App;
using Android.Widget;
using Android.OS;

namespace multileveltree
{
    [Activity(Label = "multileveltree", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        ExpandableListView expListview;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            expListview = FindViewById<ExpandableListView>(Resource.Id.ParentLevel);
            expListview.SetAdapter(new ParentView());
        }
    }
}


