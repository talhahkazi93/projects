package com.project.sportsspots.adapters;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import android.content.Context;
import android.graphics.Typeface;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseExpandableListAdapter;
import android.widget.TextView;

import com.approxen.permigiani.R;
import com.project.sportsspots.models.WatchCatgoryModelParent;
import com.project.sportsspots.models.WatchSubCategoryModelChild;

public class WatchCategoryAdapter extends BaseExpandableListAdapter {

	private Context context;
	private LayoutInflater inflater;
	// private ArrayList<WatchCatgoryModelParent> mList;
	Map<String, List<String>> cList;
	ArrayList<String> groupList;

	public WatchCategoryAdapter(Context c, int i, ArrayList<String> object,
			Map<String, List<String>> mobject) {
		// TODO Auto-generated constructor stub

		groupList = object;
		this.context = c;
		this.cList = mobject;
		this.inflater = (LayoutInflater) context
				.getSystemService(context.LAYOUT_INFLATER_SERVICE);

	}

	@Override
	public Object getChild(int groupPosition, int childPosition) {
		// TODO Auto-generated method stub
		return cList.get(groupList.get(groupPosition)).get(childPosition);
	}

	@Override
	public long getChildId(int groupPosition, int childPosition) {
		// TODO Auto-generated method stub
		return childPosition;
	}

	@Override
	public View getChildView(int groupPos, int childPos, boolean arg2,
			View convertView, ViewGroup arg4) {
		// TODO Auto-generated method stub

		// ArrayList<WatchSubCategoryModelChild> childList = new
		// ArrayList<WatchSubCategoryModelChild>();

		String childName = (String) getChild(groupPos, childPos);

		if (convertView == null) {
			convertView = inflater.inflate(R.layout.row_watch_category_child,
					null);

		}

		TextView watchSubCategoryTitle = (TextView) convertView
				.findViewById(R.id.tv_watchcategory_child);
		watchSubCategoryTitle.setText(childName);
		return convertView;
	}

	@Override
	public int getChildrenCount(int groupPos) {
		// TODO Auto-generated method stub

		if (cList.get(groupList.get(groupPos)).size() != 0) {
			return cList.get(groupList.get(groupPos)).size();
		} else
			return 0;
	}

	@Override
	public Object getGroup(int groupPosition) {
		// TODO Auto-generated method stub
		return groupList.get(groupPosition);
	}

	@Override
	public int getGroupCount() {
		// TODO Auto-generated method stub
		return groupList.size();
	}

	@Override
	public long getGroupId(int groupPosition) {
		// TODO Auto-generated method stub
		return groupPosition;
	}

	@Override
	public View getGroupView(int grouppos, boolean arg1, View convertView,
			ViewGroup arg3) {
		// TODO Auto-generated method stub

		if (convertView == null) {
			convertView = inflater.inflate(R.layout.row_watch_category_parent,
					null);
		}

		String groupTitle = (String) getGroup(grouppos);
		TextView watchCategoryTitle = (TextView) convertView
				.findViewById(R.id.tv_watchcategory_parent);

		watchCategoryTitle.setTypeface(null, Typeface.BOLD);
		watchCategoryTitle.setText(groupTitle);

		return convertView;
	}

	@Override
	public boolean hasStableIds() {
		// TODO Auto-generated method stub
		return true;
	}

	@Override
	public boolean isChildSelectable(int grouPosition, int childPosition) {
		// TODO Auto-generated method stub
		return true;
	}

}
