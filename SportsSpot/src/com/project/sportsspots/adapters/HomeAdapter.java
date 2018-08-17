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
import com.project.sportsspots.models.HomeModel;
import com.project.sportsspots.utils.CommonActions;

public class HomeAdapter extends ArrayAdapter<HomeModel> {

	LayoutInflater inflater;
	Context mContext;
	ArrayList<HomeModel> mList;
	CommonActions ca;

	public HomeAdapter(Context context, int resource,
			ArrayList<HomeModel> objects) {
		// TODO Auto-generated constructor stub
		super(context, resource, objects);

		mContext = context;
		mList = objects;
		ca = new CommonActions(context);
		Log.v("IN HOME ADAPTER", "YES");
		Log.v("IN HOME ADAPTER LIST SIZE", mList.size() + "");
		inflater = (LayoutInflater) mContext
				.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
	}

	@Override
	public View getView(int pos, View convertView, ViewGroup parent) {
		// TODO Auto-generated method stub

		if (convertView == null) {
			convertView = inflater.inflate(R.layout.fragment_row_news, null);
		}

		TextView tvNewTitle = (TextView) convertView
				.findViewById(R.id.tv_news_title);
		TextView tvNewsDes = (TextView) convertView
				.findViewById(R.id.tv_news_desciption);
		TextView tvNewsDate = (TextView) convertView
				.findViewById(R.id.tv_news_date);
		ImageView ivNewsImage = (ImageView) convertView
				.findViewById(R.id.iv_news_icon);

		// tvNewsDate.setText(formatDate(mList.get(pos).getNewsAddedDate()));
		tvNewTitle.setText(mList.get(pos).getNewsTitle());
		tvNewsDes.setText(mList.get(pos).getNewsDescription());

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

	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return mList.size();
	}

	@Override
	public HomeModel getItem(int pos) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public long getItemId(int arg0) {
		// TODO Auto-generated method stub
		return 0;
	}

}
