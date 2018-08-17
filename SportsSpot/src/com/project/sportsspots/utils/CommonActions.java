package com.project.sportsspots.utils;

import android.app.Dialog;
import android.app.ProgressDialog;
import android.content.Context;
import android.content.SharedPreferences;
import android.graphics.Typeface;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.WindowManager.BadTokenException;
import android.widget.Button;

import com.approxen.permigiani.R;

public class CommonActions {

	Context currentActivity;
	Typeface telegraphem_font;
	ProgressDialog dialog;

	public void showLoader() {

		try {

			dialog = new ProgressDialog(currentActivity);
			dialog.setMessage("Please Wait");
			dialog.setCancelable(false);
			dialog.show();
		} catch (BadTokenException e) {

		} catch (Exception e) {

		}
	}

	public void hideLoader() {

		if (dialog != null)
			dialog.cancel();
		// dialog.dismiss();
	}

	public CommonActions(Context activity) {
		// TODO Auto-generated constructor stub
		this.currentActivity = activity;

	}

	// public boolean getValueBoolean(String key, Boolean default_value) {
	//
	// SharedPreferences sharedPreferences = currentActivity
	// .getSharedPreferences(CricroxenApplication.PREF_FILE,
	// Context.MODE_PRIVATE);
	// return sharedPreferences.getBoolean(key, default_value);
	// }

	public boolean isConnectingToInternet() {
		ConnectivityManager connectivity = (ConnectivityManager) currentActivity
				.getSystemService(Context.CONNECTIVITY_SERVICE);
		if (connectivity != null) {
			NetworkInfo[] info = connectivity.getAllNetworkInfo();
			if (info != null)
				for (int i = 0; i < info.length; i++)
					if (info[i].getState() == NetworkInfo.State.CONNECTED) {
						return true;
					}

		}
		return false;
	}

	public void dialogInternet() {
		// TODO Auto-generated method stub
		final Dialog internetDialog = new Dialog(currentActivity,
				R.style.NewDialog);

		internetDialog.setContentView(R.layout.dialog_internet);

		internetDialog.show();
		Button btnOk = (Button) internetDialog.findViewById(R.id.btn_dialog_ok);

		btnOk.setOnClickListener(new OnClickListener() {

			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
				internetDialog.cancel();

			}
		});

	}

	public String createUrlFromQuery(String query) {
		String prefix = currentActivity.getResources().getString(
				R.string.url_prefix);
		String postfix = currentActivity.getResources().getString(
				R.string.url_postfix);
		String mQuery = query.replaceAll(" ", "%20");
		String finalUrl = prefix + mQuery + postfix;
		return finalUrl;
	}

}
