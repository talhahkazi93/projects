package com.project.sportsspots.activities;

import java.util.ArrayList;

import org.json.JSONArray;
import org.json.JSONObject;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ListView;
import android.widget.Toast;

import com.approxen.permigiani.R;
import com.project.sportsspots.HttpHelper.HttpGetRequest;
import com.project.sportsspots.HttpHelper.HttpResponseListener;
import com.project.sportsspots.adapters.FootballSeasonAdapter;
import com.project.sportsspots.models.FootballSeasonModel;
import com.project.sportsspots.utils.CommonActions;
import com.project.sportsspots.utils.CommonObjects;
import com.project.sportsspots.utils.ConnectionDetector;

public class FootballActivity extends Activity implements HttpResponseListener {

	ListView lvFSeasons;
	FootballSeasonAdapter fSeasonAdap;
	HttpGetRequest getRequest;
	CommonActions ca;
	ConnectionDetector cd;

	ArrayList<FootballSeasonModel> footballSeasonList;
	FootballSeasonAdapter fAdapter;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_football_seasons);
		ca = new CommonActions(FootballActivity.this);
		cd = new ConnectionDetector(getApplicationContext());
		lvFSeasons = (ListView) findViewById(R.id.lv_football_season);
		applyfunctionality();

	}

	private void applyfunctionality() {
		// TODO Auto-generated method stub

		if (!cd.isConnectingToInternet()) {

			cd.displayInternetAlert();

		} else {
			String url = "http://www.football-data.org/soccerseasons/";
			getRequest = new HttpGetRequest(url, this, "1");
			getRequest.execute();

		}

	}

	@Override
	public void beforeServiceHit() {
		// TODO Auto-generated method stub
		ca.showLoader();

	}

	@Override
	public void onResponse(String resp, String handleId) {
		// TODO Auto-generated method stub

		if (handleId.equals("1")) {
			Log.v("handle Id 1", "yes");
			if (resp != null) {
				if (!CommonObjects.testEmpty(resp)) {
					footballSeasonList = new ArrayList<FootballSeasonModel>();
					parseTeamResponse(resp);
					lvFSeasons
							.setOnItemClickListener(new OnItemClickListener() {

								@Override
								public void onItemClick(AdapterView<?> arg0,
										View v, int pos, long arg3) {
									// TODO Auto-generated method stub

									Intent nextScreen = new Intent(
											FootballActivity.this,
											FootballTeamsActivity.class);

									Bundle bundle = new Bundle();
									bundle.putString("league_id",
											footballSeasonList.get(pos)
													.getFootballId());
									nextScreen.putExtras(bundle);
									startActivity(nextScreen);

								}
							});

				} else {
					ca.hideLoader();
					Toast.makeText(
							this,
							""
									+ this.getResources().getString(
											R.string.no_record_found),
							Toast.LENGTH_SHORT).show();
				}

			} else {
				ca.hideLoader();
				Toast.makeText(
						this,
						""
								+ this.getResources().getString(
										R.string.error_occured),
						Toast.LENGTH_SHORT).show();
			}
		}

	}

	private void parseTeamResponse(String resp) {
		// TODO Auto-generated method stub
		try {
			JSONArray jArray = new JSONArray(resp);

			for (int i = 0; i < jArray.length(); i++) {
				JSONObject dataObj = jArray.getJSONObject(i);
				FootballSeasonModel mModel = new FootballSeasonModel();
				mModel.setFootballId("" + dataObj.getString("id"));
				mModel.setFootballCaption("" + dataObj.getString("caption"));
				mModel.setFootballLeague("" + dataObj.getString("league"));
				mModel.setFootballYear("" + dataObj.getString("year"));
				mModel.setFootballLastUpdated(""
						+ dataObj.getString("lastUpdated"));
				footballSeasonList.add(mModel);
			}
			fSeasonAdap = new FootballSeasonAdapter(this, 0, footballSeasonList);
			lvFSeasons.setAdapter(fSeasonAdap);
			ca.hideLoader();

		} catch (Exception e) {

		}

	}
}
