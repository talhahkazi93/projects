package com.project.sportsspots;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.util.Log;

import com.approxen.permigiani.R;
import com.project.sportsspots.activities.DemoActivity;
import com.project.sportsspots.utils.CommonActions;
import com.project.sportsspots.utils.ConnectionDetector;

public class SplashActivity extends Activity {

	private static final int SPLASH_DISPLAY_TIME = 2500;
	String regId;
	ConnectionDetector cd;
	CommonActions ca;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);

		cd = new ConnectionDetector(getApplicationContext());
		ca = new CommonActions(this);

		new CountDownTimer(10000, 1000) {

			public void onTick(long millisUntilFinished) {

			}

			public void onFinish() {
				Log.v("timer chala", "yes");
			}
		}.start();

		new CountDownTimer(5000, 100) {

			public void onTick(long millisUntilFinished) {

			}

			public void onFinish() {
				Intent intent = new Intent();

				intent.setClass(SplashActivity.this, DemoActivity.class);
				Log.v("timer chala", "yes");

				startActivity(intent);
				SplashActivity.this.finish();

			}
		}.start();

	}

}
