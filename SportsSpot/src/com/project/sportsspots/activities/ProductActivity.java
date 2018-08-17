package com.project.sportsspots.activities;

import android.app.Activity;
import android.os.Bundle;
import android.support.v4.view.ViewPager;

import com.approxen.permigiani.R;
import com.project.sportsspots.adapters.ImageSliderAdapter;
import com.viewpagerindicator.CirclePageIndicator;

public class ProductActivity extends Activity {

	ImageSliderAdapter sliderAdap;
	ViewPager mPager;
	CirclePageIndicator cIndicator;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);

		setContentView(R.layout.activity_product);
		setupViews();

		sliderAdap = new ImageSliderAdapter(getApplicationContext());
		mPager.setAdapter(sliderAdap);

		cIndicator.setViewPager(mPager);
		((CirclePageIndicator) cIndicator).setSnap(true);

	}

	private void setupViews() {
		// TODO Auto-generated method stub
		mPager = (ViewPager) findViewById(R.id.pagerProduct);
		cIndicator = (CirclePageIndicator) findViewById(R.id.indicatorProduct);

	}

}
