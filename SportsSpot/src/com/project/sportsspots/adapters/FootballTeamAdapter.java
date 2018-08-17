package com.project.sportsspots.adapters;

import java.util.ArrayList;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.approxen.permigiani.R;
import com.project.sportsspots.models.FootballTeamModel;
import com.project.sportsspots.utils.CommonActions;
import com.squareup.picasso.Picasso;

public class FootballTeamAdapter extends ArrayAdapter<FootballTeamModel> {

	LayoutInflater inflater;
	Context mContext;
	ArrayList<FootballTeamModel> mList;
	CommonActions ca;

	public FootballTeamAdapter(Context context, int resource,
			ArrayList<FootballTeamModel> objects) {
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
			convertView = inflater.inflate(R.layout.row_football_team, null);
		}

		TextView tvTeamTitle = (TextView) convertView
				.findViewById(R.id.tv_team_title);
		TextView tvTeamnDescription = (TextView) convertView
				.findViewById(R.id.tv_team_desciption);
		ImageView ivTeamImg = (ImageView) convertView
				.findViewById(R.id.iv_team_icon);

		tvTeamTitle.setText(mList.get(pos).getTeamShortName());
		tvTeamnDescription.setText(mList.get(pos).getTeamName());
		Picasso.with(mContext).load(mList.get(pos).getTeamImgUrl())
				.error(R.drawable.logo).into(ivTeamImg);

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
