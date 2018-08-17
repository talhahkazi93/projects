package com.example.calculator;

import android.app.Activity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

public class ActivityCalculator extends Activity {

	// declaring variable and widgets as required
	TextView txtResult; // Reference to EditText of result
	float result = 0; // Result of computation
	String inStr = "0"; // Current input string
	// Previous operator: '+', '-', '*', '/', '=' or ' ' (no operator)
	String lastOperator = " ";
	boolean isPoint = false;
	String operator = "";
	String previousNum = "";
	RadioButton deg, rad;
	Button sto, rcl, mplus, mminus, rem;// buttons for memory operations
	double Conversion = Math.PI / 180;// to convert to fraction
	boolean isClick = false;
	boolean isPower = false;
	int i = 0, k;
	SharedPreferences pref;// to store data

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_calculator);
		setupviews();
	}

	private void setupviews() {
		// TODO Auto-generated method stub

		txtResult = (TextView) findViewById(R.id.display);
		txtResult.setText("0");// set default to 0

		// Register listener (this class) for all the buttons
		BtnListener listener = new BtnListener();
		((Button) findViewById(R.id.Button0)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button1)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button2)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button3)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button4)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button5)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button6)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button7)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button8)).setOnClickListener(listener);
		((Button) findViewById(R.id.Button9)).setOnClickListener(listener);
		((Button) findViewById(R.id.Buttonadd)).setOnClickListener(listener);
		((Button) findViewById(R.id.ButtonSub)).setOnClickListener(listener);
		((Button) findViewById(R.id.Buttonmultiply))
				.setOnClickListener(listener);
		((Button) findViewById(R.id.ButtonDivide)).setOnClickListener(listener);
		((Button) findViewById(R.id.ButtonDelete)).setOnClickListener(listener);
		((Button) findViewById(R.id.Buttonbraces)).setOnClickListener(listener);
		((Button) findViewById(R.id.ButtonEqual)).setOnClickListener(listener);
		((Button) findViewById(R.id.ButtonDot)).setOnClickListener(listener);
		((Button) findViewById(R.id.buttonAdvancedPanel))
				.setOnClickListener(listener);

	}

	private class BtnListener implements OnClickListener {
		// On-click event handler for all the buttons
		@Override
		public void onClick(View view) {
			switch (view.getId()) {
			// Number buttons: '0' to '9'
			case R.id.Button0:
			case R.id.Button1:
			case R.id.Button2:
			case R.id.Button3:
			case R.id.Button4:
			case R.id.Button5:
			case R.id.Button6:
			case R.id.Button7:
			case R.id.Button8:
			case R.id.Button9:
			case R.id.ButtonDot:

				String inDigit = ((Button) view).getText().toString();
				if (inStr.equals("0")) {
					inStr = inDigit; // no leading zero
				} else if (inStr == previousNum) {
					inStr = inDigit;
				}

				else {
					inStr += inDigit; // accumulate input digit
				}
				txtResult.setText(inStr);
				break;

			case R.id.ButtonEqual:// operation of equal button

				if (operator == "") {
					if (isPower = true)// power calculation
					{
						Log.d("tag", inStr);

						calculatePower();
						// inStr=previousNum;
					}
					inStr = inStr;
					inStr = String.valueOf(previousNum);

				} else if (operator == "+")// plus operation
				{

					result = Float.parseFloat(previousNum)
							+ Float.parseFloat(inStr);
					txtResult.setText(String.valueOf(result));
					previousNum = String.valueOf(result);
					inStr = previousNum;
				}

				else if (operator == "-")// minus operation
				{
					result = Float.parseFloat(previousNum)
							- Float.parseFloat(inStr);
					txtResult.setText(String.valueOf(result));
					previousNum = String.valueOf(result);
					inStr = previousNum;
				}

				else if (operator == "*")// multiply oppreation
				{
					result = Float.parseFloat(previousNum)
							* Float.parseFloat(inStr);
					txtResult.setText(String.valueOf(result));
					previousNum = String.valueOf(result);
					inStr = previousNum;
				}

				else if (operator == "/")// divide operation
				{
					if (isPower == false)
						result = Float.parseFloat(previousNum)
								/ Float.parseFloat(inStr);
					else
						result = Float.parseFloat(previousNum)
								/ Float.parseFloat(calculatePower());

					txtResult.setText(String.valueOf(result));
					// txtResult.setText(reduce(Float.parseFloat(previousNum),Float.parseFloat(inStr)));

					previousNum = String.valueOf(result);
					inStr = previousNum;
					isPower = false;
				} else
					txtResult.setText("0");

				break;

			case R.id.Buttonadd:

				previousNum = inStr;
				txtResult.setText(previousNum + "+");
				inStr = "0";
				operator = "+";
				break;

			case R.id.ButtonSub:
				previousNum = inStr;
				txtResult.setText(previousNum + "-");
				inStr = "0";
				operator = "-";
				break;

			case R.id.Buttonmultiply:
				previousNum = inStr;
				txtResult.setText(previousNum + "*");
				inStr = "0";
				operator = "*";
				break;

			case R.id.ButtonDivide:
				previousNum = inStr;
				txtResult.setText(previousNum + "/");
				inStr = "0";
				operator = "/";
				break;

			case R.id.ButtonDelete:// clear function
				txtResult.setText("");
				result = 0;
				previousNum = "";
				inStr = "";
				break;

			case R.id.buttonAdvancedPanel:// clear function

				Intent nextScreen = new Intent(getApplicationContext(),
						TechActivity.class);

				startActivity(nextScreen);

				break;

			}

		}

		private String calculatePower() {// calculation of powers
			// TODO Auto-generated method stub
			char[] cArr = inStr.toCharArray();
			inStr = "";
			String s = "";
			int x = 0;
			for (int i = 0; i < cArr.length; i++) {
				if (cArr[i] != '^') {
					// x=i;
					s += cArr[i];
				} else {
					x = i;
					break;
				}
			}
			Log.d("tag", "i Is " + String.valueOf(x));

			for (int j = x + 1; j < cArr.length; j++) {
				inStr += cArr[j];
			}

			Log.d("tag", s);
			Log.d("tag", inStr);

			result = (float) Math.pow(Double.parseDouble(s),
					Double.parseDouble(inStr));
			txtResult.setText(String.valueOf(result));
			inStr = String.valueOf(result);
			return inStr;
		}

	}
}
