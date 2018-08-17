package com.project.sportsspots.adapters;

import android.content.Context;
import android.support.v4.view.PagerAdapter;
import android.support.v4.view.ViewPager;
import android.view.View;
import android.widget.ImageView;

import com.approxen.permigiani.R;
import com.viewpagerindicator.IconPagerAdapter;

public class ImageSliderAdapter extends PagerAdapter implements
		IconPagerAdapter {

	private int[] Images = new int[] { R.drawable.banner_1,
			R.drawable.banner_2, R.drawable.banner_3, R.drawable.banner_4,
			R.drawable.banner_5, R.drawable.banner_6 };

	protected static final int[] ICONS = new int[] {
			R.drawable.custom_tab_indicator_selected,
			R.drawable.custom_tab_indicator_selected,
			R.drawable.custom_tab_indicator_selected,
			R.drawable.custom_tab_indicator_selected };

	private int mCount = Images.length;
	Context mcontext;

	public ImageSliderAdapter(Context context) {
		// TODO Auto-generated constructor stub
		this.mcontext = context;
	}

	@Override
	public int getIconResId(int index) {
		// TODO Auto-generated method stub
		return ICONS[index % ICONS.length];
	}

	public void setCount(int count) {
		if (count > 0 && count <= 10) {
			mCount = count;
			notifyDataSetChanged();
		}
	}

	@Override
	public Object instantiateItem(View container, int position) {
		// TODO Auto-generated method stub

		ImageView imageView = new ImageView(mcontext);
		/*
		 * int padding = context.getResources().getDimensionPixelSize(
		 * R.dimen.padding_medium); imageView.setPadding(padding, padding,
		 * padding, padding);
		 */
		imageView.setScaleType(ImageView.ScaleType.CENTER_INSIDE);
		imageView.setImageResource(Images[position]);
		((ViewPager) container).addView(imageView, 0);
		return imageView;
	}

	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return mCount;
	}

	@Override
	public boolean isViewFromObject(View view, Object object) {
		// TODO Auto-generated method stub
		return view == ((ImageView) object);
	}

	@Override
	public void destroyItem(View container, int position, Object object) {
		// TODO Auto-generated method stub
		((ViewPager) container).removeView((ImageView) object);
	}

}
