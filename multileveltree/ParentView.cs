
using System;

using Android.App;
using Android.Content;
using Android.Database;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace multileveltree
{
    public class ParentView : BaseExpandableListAdapter
    {
        public override int GroupCount
        {
            get {
                return 5;
            }
        }

        public override bool HasStableIds
        {
            get {
                return true;
            }
        }

        public override bool IsEmpty
        {
            get {
                return false;
            }
        }

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override bool AreAllItemsEnabled()
        {
            return true;
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override int GetChildrenCount(int groupPosition)
        {
            return 3;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            var SecondLevelexplv = new CustExpListview(Application.Context);
            SecondLevelexplv.SetAdapter(new SecondLevelAdapter());
            SecondLevelexplv.SetGroupIndicator(null);
            return SecondLevelexplv;
        }

        public override long GetCombinedChildId(long groupId, long childId)
        {
            return childId;
        }

        public override long GetCombinedGroupId(long groupId)
        {
            return groupId;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            return groupPosition;
        }

        public override long GetGroupId(int groupPosition)
        {
            return groupPosition;
        }

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            var tv = new TextView(Application.Context)
            {
                Text = "->FirstLevel",
            };
            tv.SetBackgroundColor(Color.Blue);
            tv.SetPadding(10, 7, 7, 7);

            return tv;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return true;
        }

        public override void OnGroupCollapsed(int groupPosition)
        {
            //throw new NotImplementedException();
        }

        public override void OnGroupExpanded(int groupPosition)
        {
            //throw new NotImplementedException();
        }

        public override void RegisterDataSetObserver(DataSetObserver observer)
        {
            //throw new NotImplementedException();
        }

        public override void UnregisterDataSetObserver(DataSetObserver observer)
        {
            //throw new NotImplementedException();
        }
    }
}

public class CustExpListview : ExpandableListView
{

    int intGroupPosition, intChildPosition, intGroupid;


    public CustExpListview(Context context) : base(context)
    {
    }

    protected void onMeasure(int widthMeasureSpec, int heightMeasureSpec)
    {
        widthMeasureSpec = MeasureSpec.MakeMeasureSpec(960, MeasureSpecMode.AtMost);
        heightMeasureSpec = MeasureSpec.MakeMeasureSpec(600, MeasureSpecMode.AtMost);
        OnMeasure(widthMeasureSpec, heightMeasureSpec);
    }
}

public class SecondLevelAdapter : BaseExpandableListAdapter
{
    public override int GroupCount
    {
        get {
            return 1;
        }
    }

    public override bool HasStableIds
    {
        get {
            return true;
        }
    }

    public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
    {
        return childPosition;
    }

    public override long GetChildId(int groupPosition, int childPosition)
    {
        return childPosition;
    }

    public override int GetChildrenCount(int groupPosition)
    {
        return 5;
    }

    public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
    {
        var tv = new TextView(Application.Context)
        {
            Text = "child"
        };
        tv.SetPadding(15, 5, 5, 5);
        tv.SetBackgroundColor(Color.Yellow);
        return tv;
    }

    public override Java.Lang.Object GetGroup(int groupPosition)
    {
        return groupPosition;
    }

    public override long GetGroupId(int groupPosition)
    {
        return groupPosition;
    }

    public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
    {
        var tv = new TextView(Application.Context)
        {
            Text = "-->second level"
        };
        tv.SetPadding(12, 7, 7, 7);
        tv.SetBackgroundColor(Color.Red);

        return tv;
    }

    public override bool IsChildSelectable(int groupPosition, int childPosition)
    {
        return true;
    }
}

