package com.project.sportsspots.HttpHelper;

import android.os.AsyncTask;

import com.project.sportsspots.utils.RestClient;
import com.project.sportsspots.utils.RestClient.RequestMethod;

public class HttpGetRequest extends AsyncTask<Void, Void, String> {

	String mUrl;
	HttpResponseListener mListener;
	String mHandleId;

	public HttpGetRequest(String url, HttpResponseListener lis, String handleId) {
		// TODO Auto-generated constructor stub
		mUrl = url;
		mListener = lis;
		mHandleId = handleId;
	}

	@Override
	protected void onPreExecute() {
		// TODO Auto-generated method stub
		super.onPreExecute();
		mListener.beforeServiceHit();
	}

	@Override
	protected String doInBackground(Void... params) {
		// TODO Auto-generated method stub
		RestClient obj = new RestClient(mUrl);
		try {
			obj.Execute(RequestMethod.GET);
			// resp = obj.getResponse();
			return obj.getResponse();
		} catch (Exception e) {
			// TODO Auto-generated catch block

			e.printStackTrace();
			return null;
		}

	}

	@Override
	protected void onPostExecute(String result) {
		// TODO Auto-generated method stub
		super.onPostExecute(result);

		mListener.onResponse(result, mHandleId);
	}

}
