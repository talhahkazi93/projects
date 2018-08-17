package com.project.sportsspots.activities;

import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ExpandableListView;
import android.widget.ExpandableListView.OnChildClickListener;

import com.approxen.permigiani.R;
import com.project.sportsspots.adapters.WatchCategoryAdapter;
import com.project.sportsspots.models.WatchCatgoryModelParent;
import com.project.sportsspots.models.WatchSubCategoryModelChild;

public class WatchCategoryActivity extends Activity {

	ExpandableListView eLv;
	ArrayList<WatchCatgoryModelParent> aList = new ArrayList<WatchCatgoryModelParent>();
	ArrayList<WatchSubCategoryModelChild> cList = new ArrayList<WatchSubCategoryModelChild>();
	WatchCategoryAdapter adapterWatches;

	Map<String, List<String>> collectionSubCategory;
	ArrayList<String> parentList;
	ArrayList<String> childList = new ArrayList<String>();

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);

		setContentView(R.layout.activity_watch_category);
		setupviews();
		applyFunctionality();

	}

	private void applyFunctionality() {
		// TODO Auto-generated method stub

		// aList = getData();

		createGroupList();
		createCollections();

		adapterWatches = new WatchCategoryAdapter(this, 0, parentList,
				collectionSubCategory);
		eLv.setAdapter(adapterWatches);

		eLv.setOnChildClickListener(new OnChildClickListener() {

			@Override
			public boolean onChildClick(ExpandableListView arg0, View arg1,
					int arg2, int arg3, long arg4) {
				// TODO Auto-generated method stub

				Intent intentSetup = new Intent(getApplicationContext(),
						ProductActivity.class);

				startActivity(intentSetup);

				return true;
			}
		});

	}

	private void createGroupList() {
		// TODO Auto-generated method stub

		parentList = new ArrayList<String>();
		parentList.add("Gents");
		parentList.add("Ladies");
		parentList.add("Haute Horlogerie");
		parentList.add("Pieces of exception");

	}

	private ArrayList<WatchCatgoryModelParent> getData() {
		// TODO Auto-generated method stub

		ArrayList<WatchCatgoryModelParent> result = new ArrayList<WatchCatgoryModelParent>();
		WatchCatgoryModelParent m = new WatchCatgoryModelParent();
		// cList = getWatchCategories();

		m.setWatchCategoryId("1");
		m.setWatchCategoryTitle("Gents Collection");
		result.add(m);

		m = new WatchCatgoryModelParent();
		m.setWatchCategoryId("2");
		m.setWatchCategoryTitle("Ladies Collection");
		result.add(m);

		m = new WatchCatgoryModelParent();
		m.setWatchCategoryId("3");
		m.setWatchCategoryTitle("Haute Horlogerie");
		result.add(m);

		m = new WatchCatgoryModelParent();
		m.setWatchCategoryId("4");
		m.setWatchCategoryTitle("Pieces of exception");
		result.add(m);

		return result;
	}

	private void createCollections() {
		String[] gents = { "Kalpa", "Tonda", "Bugati", "Pershing",
				"Transforma", "Toric" };
		String[] ladies = { "Kalpa", "Tonda", "Bugati" };
		String[] HauteHorlogerie = { "Toric", "Kalpa", "Tonda", "Bugati" };
		String[] pieceOfException = { "The cat and Mouse", "Finonnaci",
				"the hegirian and the pearl of wisbom" };

		collectionSubCategory = new LinkedHashMap<String, List<String>>();

		for (String category : parentList) {

			if (category.equals("Gents Collection")) {
				loadChild(gents);
			} else if (category.equals("Ladies Collection")) {
				loadChild(ladies);
			} else if (category.equals("Haute Horlogerie")) {
				loadChild(HauteHorlogerie);
			} else
				loadChild(pieceOfException);

			collectionSubCategory.put(category, childList);

		}

	}

	private void loadChild(String[] childData) {
		childList = new ArrayList<String>();
		for (String model : childData)
			childList.add(model);
	}

	private ArrayList<WatchSubCategoryModelChild> getWatchCategories() {
		// TODO Auto-generated method stub

		ArrayList<WatchSubCategoryModelChild> result = new ArrayList<WatchSubCategoryModelChild>();
		WatchSubCategoryModelChild mChild = new WatchSubCategoryModelChild();
		mChild.setWatchSubCategoryTitle("Kalpa");
		result.add(mChild);

		mChild = new WatchSubCategoryModelChild();
		mChild.setWatchSubCategoryTitle("Tonda");
		result.add(mChild);

		mChild = new WatchSubCategoryModelChild();
		mChild.setWatchSubCategoryTitle("Bugati");
		result.add(mChild);

		mChild = new WatchSubCategoryModelChild();
		mChild.setWatchSubCategoryTitle("Pershing");
		result.add(mChild);

		mChild = new WatchSubCategoryModelChild();
		mChild.setWatchSubCategoryTitle("Ovale");
		result.add(mChild);

		mChild = new WatchSubCategoryModelChild();
		mChild.setWatchSubCategoryTitle("Transforma");
		result.add(mChild);

		mChild = new WatchSubCategoryModelChild();
		mChild.setWatchSubCategoryTitle("Toric");
		result.add(mChild);

		return result;
	}

	private void setupviews() {
		// TODO Auto-generated method stub

		eLv = (ExpandableListView) findViewById(R.id.elv_watchCategory);

	}

}
