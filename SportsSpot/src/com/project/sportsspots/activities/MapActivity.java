package com.project.sportsspots.activities;

import android.app.Activity;
import android.os.Bundle;
import android.view.Window;
import android.view.WindowManager;

import com.approxen.permigiani.R;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.LatLngBounds;
import com.project.sportsspots.utils.ConnectionDetector;

public class MapActivity extends Activity {

	private GoogleMap googleMap;
	LatLngBounds mBound;
	LatLng myLatLng;
	ConnectionDetector cd;
	String destlat, destlong;
	double stlat = 0, stlon = 0, endlat = 0, endlon = 0, mlat, mlong;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);

		setContentView(R.layout.activity_map);

	}
}