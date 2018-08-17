package com.project.sportsspots.activities;

import java.util.ArrayList;

import android.app.Activity;
import android.os.Bundle;
import android.support.v4.view.ViewPager;
import android.util.Log;
import android.widget.ListView;
import com.approxen.permigiani.R;
import com.project.sportsspots.adapters.HomeAdapter;
import com.project.sportsspots.adapters.ImageSliderAdapter;
import com.project.sportsspots.models.HomeModel;
import com.viewpagerindicator.CirclePageIndicator;

public class HomeActivity extends Activity {

	ListView lvHomeNews;
	ArrayList<HomeModel> aList;
	ViewPager mPager;
	CirclePageIndicator cIndicator;
	private String[] ImagesEng;
	ImageSliderAdapter sliderAdap;
	HomeAdapter newsAdapter;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		setupViews();
		applyfunctionality();

	}

	private void applyfunctionality() {
		// TODO Auto-generated method stub

		// // Image Slider
		sliderAdap = new ImageSliderAdapter(getApplicationContext());
		mPager.setAdapter(sliderAdap);
		cIndicator.setViewPager(mPager);
		((CirclePageIndicator) cIndicator).setSnap(true);

		// // list view
		aList = new ArrayList<HomeModel>();
		aList = getData();
		Log.v("alist size", aList.size() + "");
		newsAdapter = new HomeAdapter(this, 0, aList);
		lvHomeNews.setAdapter(newsAdapter);

	}

	private ArrayList<HomeModel> getData() {
		// TODO Auto-generated method stub

		ArrayList<HomeModel> result = new ArrayList<HomeModel>();
		HomeModel mHome = new HomeModel();
		mHome.setNewsId("1");
		mHome.setNewsTitle("News 1");
		mHome.setNewsDescription("lorem upsam 1");
		mHome.setNewsAddedDate("10/15/2015");
		result.add(mHome);

		mHome = new HomeModel();
		mHome.setNewsId("1");
		mHome.setNewsTitle("News 2");
		mHome.setNewsDescription("lorem upsam 2");
		mHome.setNewsAddedDate("10/15/2015");
		result.add(mHome);

		mHome = new HomeModel();
		mHome.setNewsId("1");
		mHome.setNewsTitle("News 3");
		mHome.setNewsDescription("lorem upsam 3");
		mHome.setNewsAddedDate("10/15/2015");
		result.add(mHome);

		mHome = new HomeModel();
		mHome.setNewsId("1");
		mHome.setNewsTitle("News 4");
		mHome.setNewsDescription("lorem upsam 4");
		mHome.setNewsAddedDate("10/15/2015");
		result.add(mHome);

		mHome = new HomeModel();
		mHome.setNewsId("1");
		mHome.setNewsTitle("News 5");
		mHome.setNewsAddedDate("10/15/2015");
		mHome.setNewsDescription("lorem upsam 5");
		result.add(mHome);

		return result;
	}

	private void setupViews() {
		// TODO Auto-generated method stub
		lvHomeNews = (ListView) findViewById(R.id.lvNews);
		mPager = (ViewPager) findViewById(R.id.pager);
		cIndicator = (CirclePageIndicator) findViewById(R.id.indicator);

	}

}
