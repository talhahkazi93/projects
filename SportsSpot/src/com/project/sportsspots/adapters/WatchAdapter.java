package com.project.sportsspots.adapters;

import android.content.Context;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageButton;
import android.widget.ImageView;

import com.approxen.permigiani.R;

public class WatchAdapter extends BaseAdapter {

	private Context mContext;
	private final String[] web;
	private final int[] Imageid;

	public WatchAdapter(Context c, String[] web, int[] imageId) {
		// TODO Auto-generated constructor stub
		mContext = c;
		this.Imageid = imageId;
		this.web = web;

		Log.v("WEB NAMES", web + "");
		Log.v("Image ids", imageId + "");

	}

	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return web.length;
	}

	@Override
	public Object getItem(int pos) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public long getItemId(int pos) {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public View getView(int pos, View convertView, ViewGroup parent) {
		// TODO Auto-generated method stub

		View grid;
		LayoutInflater inflater = (LayoutInflater) mContext
				.getSystemService(Context.LAYOUT_INFLATER_SERVICE);

		if (convertView == null) {
			grid = new View(mContext);
			grid = inflater.inflate(R.layout.grid_watch_single, null);
			ImageView ivWatches = (ImageView) grid.findViewById(R.id.ivWatches);
			ivWatches.setImageResource(Imageid[pos]);

		} else {
			grid = (View) convertView;
		}

		return grid;
	}

}
