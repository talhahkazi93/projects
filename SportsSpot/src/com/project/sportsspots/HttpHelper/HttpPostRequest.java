package com.project.sportsspots.HttpHelper;

import java.io.IOException;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.mime.MultipartEntity;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.util.EntityUtils;

import android.os.AsyncTask;

public class HttpPostRequest extends AsyncTask<Void, Void, String> {

	String mUrl;
	HttpResponseListener mListener;
	String mHandleId;
	MultipartEntity mpEntity;

	public HttpPostRequest(String url, HttpResponseListener lis,
			String handleId, MultipartEntity mp) {
		// TODO Auto-generated constructor stub
		mUrl = url;
		mListener = lis;
		mHandleId = handleId;
		mpEntity = mp;
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
		HttpClient client = new DefaultHttpClient();
		HttpPost post = new HttpPost(mUrl);

		post.setEntity(mpEntity);
		HttpResponse response1;
		try {
			response1 = client.execute(post);
			HttpEntity resEntity = response1.getEntity();

			return EntityUtils.toString(resEntity);
		} catch (ClientProtocolException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return null;
	}

	@Override
	protected void onPostExecute(String result) {
		// TODO Auto-generated method stub
		super.onPostExecute(result);

		mListener.onResponse(result, mHandleId);
	}

}