package com.project.sportsspots.utils;

import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.UnsupportedEncodingException;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLEncoder;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import android.app.Dialog;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.util.Base64;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

import com.approxen.permigiani.R;

public class CommonObjects {

	public static final String APP_NAME_TAG = "iMassage LOG";

	public static final String DATA = "data";
	public static final String MESSAGE = "message";
	public static final String ERROR = "error";
	public static final String STATUS = "status";
	public static final String DEVICE_TYPE = "1";
	public static String lpc;

	public static boolean testEmpty(String str) {
		if ((str == null) || str.matches("^\\s*$")) {
			return true;
		} else {
			if (str.equalsIgnoreCase("null")) {
				return true;
			} else {
				return false;
			}
		}
	}

	public static boolean isEmailValid(String email) {
		boolean isValid = false;

		String expression = "^[\\w\\.-]+@([\\w\\-]+\\.)+[A-Z]{2,4}$";
		CharSequence inputStr = email;
		Pattern pattern = Pattern.compile(expression, Pattern.CASE_INSENSITIVE);
		Matcher matcher = pattern.matcher(inputStr);

		if (matcher.matches()) {
			isValid = true;
		}

		return isValid;
	}

	public static boolean isValidUrl(String url) {
		try {
			new URL(url);
			return true;
		} catch (MalformedURLException e) {
			return false;
		}
	}

	public static boolean isNumeric(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException nfe) {
			return false;
		}
		return true;
	}

	public static boolean Is_Valid_Person_Name(String str)
			throws NumberFormatException {
		if (!str.matches("[a-zA-Z ]+")) {
			return false;
		} else {
			return true;
		}

	}

	public static boolean testWrongPassword(String str) {
		if ((str == null) || str.matches("^\\s*$") || str.length() < 6) {
			return true;
		} else {
			if (str.equalsIgnoreCase("null")) {
				return true;
			} else {
				return false;
			}
		}
	}

	public static String getEncodedURLSpaces(String catName) {

		if (catName.contains(" ")) {

			String[] splitArr = catName.split(" ");
			catName = "";
			for (int i = 0; i < splitArr.length; i++) {

				if (i == splitArr.length - 1) {
					catName += splitArr[i];

				} else {
					catName += splitArr[i] + "%20";
				}
			}
		}
		return catName;
	}

	public static String getColoredRanks(String rank) {

		String result = null;
		int rankCount = rank.length();

		// + "<font color='#EE0000'>"
		// + netSalary
		// + "</font>"

		switch (rankCount) {
		case 1:

			result = "<font color='#3B863B'>$</font>" + " $ $ $</font>";

			break;

		case 2:

			result = "<font color='#3B863B'>$ $</font>" + " $ $</font>";

			break;

		case 3:

			result = "<font color='#3B863B'>$ $ $</font>" + " $</font>";

			break;

		case 4:

			result = "<font color='#3B863B'>$ $ $ $</font>";

			break;

		default:

			result = rank;
			break;
		}

		return result;

	}

	public static String getBitmapFromURL(String src) {
		try {
			ByteArrayOutputStream baos = new ByteArrayOutputStream();
			String img_str;
			URL url = new URL(src);
			HttpURLConnection connection = (HttpURLConnection) url
					.openConnection();
			connection.setDoInput(true);
			connection.connect();
			InputStream input = connection.getInputStream();
			Bitmap myBitmap = BitmapFactory.decodeStream(input);

			myBitmap.compress(Bitmap.CompressFormat.JPEG, 100, baos);
			byte[] b = baos.toByteArray();

			img_str = new String(Base64.encode(b, Base64.DEFAULT), "UTF-8");
			// Log.v("bitmap image", myBitmap+"");

			return img_str;
		} catch (IOException e) {
			e.printStackTrace();
			return null;
		}

	}

	public static String encodeString(String email) {
		String emailAdd = null;
		try {
			emailAdd = URLEncoder.encode(email, "UTF-8");
		} catch (UnsupportedEncodingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return emailAdd;
	}

	public static String convertMd5(String s) {
		try {
			// Create MD5 Hash
			MessageDigest digest = java.security.MessageDigest
					.getInstance("MD5");
			digest.update(s.getBytes());
			byte messageDigest[] = digest.digest();

			// Create Hex String
			StringBuffer hexString = new StringBuffer();
			for (int i = 0; i < messageDigest.length; i++)
				hexString.append(Integer.toHexString(0xFF & messageDigest[i]));
			return hexString.toString();

		} catch (NoSuchAlgorithmException e) {
			e.printStackTrace();
		}
		return "";
	}

	public static char[] hexDigits = "0123456789abcdef".toCharArray();

	public static String md5(InputStream is) throws IOException,
			NoSuchAlgorithmException {
		byte[] bytes = new byte[4096];
		int read = 0;
		MessageDigest digest = MessageDigest.getInstance("MD5");
		while ((read = is.read(bytes)) != -1) {
			digest.update(bytes, 0, read);
		}

		byte[] messageDigest = digest.digest();

		StringBuilder sb = new StringBuilder(32);

		// Oh yeah, this too. Integer.toHexString doesn't zero-pad, so
		// (for example) 5 becomes "5" rather than "05".
		for (byte b : messageDigest) {
			sb.append(hexDigits[(b >> 4) & 0x0f]);
			sb.append(hexDigits[b & 0x0f]);
		}

		return sb.toString();
	}

	public static byte[] convertFileToByteArray(File f) {
		byte[] byteArray = null;
		try {
			InputStream inputStream = new FileInputStream(f);
			ByteArrayOutputStream bos = new ByteArrayOutputStream();
			byte[] b = new byte[1024 * 8];
			int bytesRead = 0;

			while ((bytesRead = inputStream.read(b)) != -1) {
				bos.write(b, 0, bytesRead);
			}

			byteArray = bos.toByteArray();
			inputStream.close();

		} catch (IOException e) {
			e.printStackTrace();
		}
		return byteArray;
	}

	public static void dialogInternet(Context activity) {
		// TODO Auto-generated method stub
		final Dialog internetDialog = new Dialog(activity, R.style.NewDialog);

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

}
