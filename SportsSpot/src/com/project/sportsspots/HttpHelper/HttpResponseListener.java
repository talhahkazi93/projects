package com.project.sportsspots.HttpHelper;

public interface HttpResponseListener {

	void beforeServiceHit();

	void onResponse(String resp, String handleId);

}
