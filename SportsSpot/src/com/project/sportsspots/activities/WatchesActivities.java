package com.project.sportsspots.activities;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.GridView;
import android.widget.Toast;

import com.approxen.permigiani.R;
import com.project.sportsspots.adapters.WatchAdapter;

public class WatchesActivities extends Activity {

	GridView grid;
	String[] web = { "Men", "women", "Sports", "Techno", "Flickr", "metal" };

	int[] imageId = { R.drawable.banner1, R.drawable.banner2,
			R.drawable.banner3, R.drawable.banner4, R.drawable.banner5,
			R.drawable.banner2 };

	GridView gvWatches;
	WatchAdapter adapterWatches;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_watches);

		setupviews();
		applyfunctionality();

	}

	private void setupviews() {
		// TODO Auto-generated method stub
		gvWatches = (GridView) findViewById(R.id.gridWatches);
	}

	private void applyfunctionality() {
		// TODO Auto-generated method stub

		adapterWatches = new WatchAdapter(this, web, imageId);
		gvWatches.setAdapter(adapterWatches);
		gvWatches.setNumColumns(3);

		gvWatches.setOnItemClickListener(new OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> arg0, View arg1, int arg2,
					long arg3) {
				// TODO Auto-generated method stub
				// Toast.makeText(WatchesActivities.this, "ImageButton clicked",
				// Toast.LENGTH_SHORT).show();

				Intent watchCategory = new Intent(getApplicationContext(),
						WatchCategoryActivity.class);
				startActivity(watchCategory);

			}
		});

	}
}
