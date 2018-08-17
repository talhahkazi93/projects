package com.project.sportsspots.adapters;

import java.util.ArrayList;

import android.content.Context;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.approxen.permigiani.R;
import com.project.sportsspots.models.FootballSeasonModel;
import com.project.sportsspots.models.HomeModel;
import com.project.sportsspots.utils.CommonActions;

public class FootballSeasonAdapter extends ArrayAdapter<FootballSeasonModel> {

	LayoutInflater inflater;
	Context mContext;
	ArrayList<FootballSeasonModel> mList;
	CommonActions ca;

	public FootballSeasonAdapter(Context context, int resource,
			ArrayList<FootballSeasonModel> objects) {
		// TODO Auto-generated constructor stub
		super(context, resource, objects);

		mContext = context;
		mList = objects;
		ca = new CommonActions(context);
		inflater = (LayoutInflater) mContext
				.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
	}

	@Override
	public View getView(int pos, View convertView, ViewGroup parent) {
		// TODO Auto-generated method stub

		if (convertView == null) {
			convertView = inflater.inflate(R.layout.row_season, null);
		}

		TextView tvFseasonCaption = (TextView) convertView
				.findViewById(R.id.tv_season_caption);
		TextView tvFseasonLeague = (TextView) convertView
				.findViewById(R.id.tv_season_league);
		TextView tvFseasonYear = (TextView) convertView
				.findViewById(R.id.tv_season_year);

		tvFseasonCaption.setText(mList.get(pos).getFootballCaption());
		tvFseasonLeague.setText(mList.get(pos).getFootballLeague());
		tvFseasonYear.setText(mList.get(pos).getFootballYear());

		return convertView;
	}

	// String formatDate(String date) {
	//
	// String resultdate;
	// String year, month, day;
	// String splitDate[] = date.split("-");
	//
	// year = splitDate[0];
	// month = splitDate[1];
	// // day = splitDate[2];
	// day = splitDate[2].substring(0, 2);
	//
	// resultdate = day + "/" + month + "/" + year;
	// return resultdate;
	// }

}
