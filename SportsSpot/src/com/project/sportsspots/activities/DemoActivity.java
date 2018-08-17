package com.project.sportsspots.activities;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

import com.approxen.permigiani.R;

public class DemoActivity extends Activity {

	Button btnHome, btnCricket, btnFootball;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);

		setContentView(R.layout.activity_demo);
		setupviews();
		applyfunctionality();

	}

	private void applyfunctionality() {
		// TODO Auto-generated method stub

		btnHome.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub

				Intent nextScreen = new Intent(getApplicationContext(),
						HomeActivity.class);

				// Sending data to another Activity
				// nextScreen.putExtra("name", inputName.getText().toString());
				// nextScreen.putExtra("email",
				// inputEmail.getText().toString());
				startActivity(nextScreen);

			}
		});

		btnCricket.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub

				Intent watchScreen = new Intent(getApplicationContext(),
						WatchesActivities.class);

				startActivity(watchScreen);

			}
		});

		btnFootball.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				Intent mapActivity = new Intent(getApplicationContext(),
						FootballActivity.class);
				startActivity(mapActivity);

			}
		});

	}

	private void setupviews() {
		// TODO Auto-generated method stub
		btnHome = (Button) findViewById(R.id.btnHome);
		btnCricket = (Button) findViewById(R.id.btnCricket);
		btnFootball = (Button) findViewById(R.id.btnfootball);
	}

}
