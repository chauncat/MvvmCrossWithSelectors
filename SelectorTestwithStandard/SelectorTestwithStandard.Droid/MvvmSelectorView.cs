using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using SelectorTestwithStandard.Core;

namespace SelectorTestwithStandard.Droid
{
    [Activity(Label = "Droid Selector", Theme = "@style/AppTheme")]
    public class MvvmSelector : MvxAppCompatActivity<MvvmSelectorViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.view_mvvm_selector);
            var recycler = FindViewById<MvxRecyclerView>(Resource.Id.test_list);
            recycler.Adapter = new ZebraRecyclerViewAdapter(BindingContext as IMvxAndroidBindingContext);
            recycler.SetLayoutManager(new LinearLayoutManager(this));
        }
    }

    public class ZebraRecyclerViewAdapter : MvxRecyclerAdapter
    {
        public ZebraRecyclerViewAdapter(IMvxAndroidBindingContext bindingContext, bool lightBackground = false) : base(bindingContext)
        {
            SetBackgroundColors(lightBackground);
        }

        private void SetBackgroundColors(bool light)
        {
            BackgroundColorId1 = Resource.Color.light1;
            BackgroundColorId2 = Resource.Color.light2;
        }


        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            base.OnBindViewHolder(holder, position);

            var one = holder.ItemView.FindViewById<TextView>(Resource.Id.oneText);
            var two = holder.ItemView.FindViewById<TextView>(Resource.Id.twoText);
            var three = holder.ItemView.FindViewById<TextView>(Resource.Id.threeText);
            var radio1 = holder.ItemView.FindViewById<AppCompatRadioButton>(Resource.Id.one);

            var dataContext = GetItem(position) as DroidListItem;
            if (dataContext != null)
            {
                radio1.Checked = dataContext.One;
                one.Text = dataContext.One.ToString();
                two.Text = dataContext.Two.ToString();
                three.Text = dataContext.Three.ToString();
            }

            ApplyZebraStripes(holder.ItemView, position);
        }

        public int BackgroundColorId1 { get; set; }
        public int BackgroundColorId2 { get; set; }

        protected void ApplyZebraStripes(View item, int position)
        {
            if (BackgroundColorId1 == 0 || BackgroundColorId2 == 0) return;
            item.SetBackgroundResource(position % 2 == 0 ? BackgroundColorId1 : BackgroundColorId2);
        }
    }
}