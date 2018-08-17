package com.project.sportsspots.models;

import java.util.ArrayList;

public class WatchCatgoryModelParent {

	private String watchCategoryId;
	private String watchCategoryTitle;
	private String watchCategoryDesc;

	private WatchSubCategoryModelChild watchsubCategoryModel;
	private ArrayList<WatchSubCategoryModelChild> alistWatchCatChild;

	public ArrayList<WatchSubCategoryModelChild> getAlistWatchCatChild() {
		return alistWatchCatChild;
	}

	public void setAlistWatchCatChild(
			ArrayList<WatchSubCategoryModelChild> alistWatchCatChild) {
		this.alistWatchCatChild = alistWatchCatChild;
	}

	public WatchSubCategoryModelChild getWatchsubCategoryModel() {
		return watchsubCategoryModel;
	}

	public void setWatchsubCategoryModel(
			WatchSubCategoryModelChild watchsubCategoryModel) {
		this.watchsubCategoryModel = watchsubCategoryModel;
	}

	public String getWatchCategoryId() {
		return watchCategoryId;
	}

	public void setWatchCategoryId(String watchCategoryId) {
		this.watchCategoryId = watchCategoryId;
	}

	public String getWatchCategoryTitle() {
		return watchCategoryTitle;
	}

	public void setWatchCategoryTitle(String watchCategoryTitle) {
		this.watchCategoryTitle = watchCategoryTitle;
	}

	public String getWatchCategoryDesc() {
		return watchCategoryDesc;
	}

	public void setWatchCategoryDesc(String watchCategoryDesc) {
		this.watchCategoryDesc = watchCategoryDesc;
	}
}
