package com.project.sportsspots.activities;

import java.util.ArrayList;

import org.json.JSONArray;
import org.json.JSONObject;

import android.app.Activity;
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
import com.project.sportsspots.adapters.FootballTeamAdapter;
import com.project.sportsspots.models.FootballTeamModel;
import com.project.sportsspots.utils.CommonActions;
import com.project.sportsspots.utils.CommonObjects;
import com.project.sportsspots.utils.ConnectionDetector;

public class FootballTeamsActivity extends Activity implements
		HttpResponseListener {

	ListView lvFteams;
	HttpGetRequest getRequest;
	CommonActions ca;
	ConnectionDetector cd;
	FootballTeamAdapter teamAdapter;
	ArrayList<FootballTeamModel> teamList;
	String sessonId;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);

		setContentView(R.layout.activity_football_teams);
		ca = new CommonActions(FootballTeamsActivity.this);
		cd = new ConnectionDetector(getApplicationContext());
		sessonId = getIntent().getExtras().getString("league_id");
		lvFteams = (ListView) findViewById(R.id.lv_football_team);
		Log.v("LEAGUE ID", sessonId + "");
		applyfunctionality();

	}

	private void applyfunctionality() {
		// TODO Auto-generated method stub

		if (!cd.isConnectingToInternet()) {

			cd.displayInternetAlert();

		} else {
			String url = "http://www.football-data.org/soccerseasons/"
					+ sessonId + "/teams";
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
					teamList = new ArrayList<FootballTeamModel>();
					parseTeamResponse(resp);
					lvFteams.setOnItemClickListener(new OnItemClickListener() {

						@Override
						public void onItemClick(AdapterView<?> arg0, View v,
								int pos, long id) {
							// TODO Auto-generated method stub

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
				FootballTeamModel mModel = new FootballTeamModel();
				mModel.setTeamId("" + dataObj.getString("id"));
				mModel.setTeamShortName("" + dataObj.getString("name"));
				mModel.setTeamName("" + dataObj.getString("shortName"));
				mModel.setTeamImgUrl("" + dataObj.getString("crestUrl"));
				teamList.add(mModel);
			}
			teamAdapter = new FootballTeamAdapter(this, 0, teamList);
			lvFteams.setAdapter(teamAdapter);
			ca.hideLoader();

		} catch (Exception e) {

		}

	}
}
