package com.example.calculator;

import android.os.Bundle;
import android.os.CountDownTimer;
import android.app.Activity;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;

public class SplashActivity extends Activity {

	private static final int SPLASH_DISPLAY_TIME = 500;
	String regId;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_splash);

		// new CountDownTimer(10000, 1000) {
		//
		// public void onTick(long millisUntilFinished) {
		//
		// }
		//
		// public void onFinish() {
		// Log.v("timer chala", "yes");
		// }
		// }.start();

		new CountDownTimer(500, 100) {

			public void onTick(long millisUntilFinished) {

			}

			public void onFinish() {
				Intent intent = new Intent();

				intent.setClass(SplashActivity.this, ActivityCalculator.class);
				Log.v("timer chala", "yes");

				startActivity(intent);
				SplashActivity.this.finish();

			}
		}.start();

	}

}
