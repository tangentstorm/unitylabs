using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

[ExecuteInEditMode]
public class Calculator : MonoBehaviour {

	public Text display;
	public decimal value;
	const int _base = 10; // numeric base (base is keyword in c#)
	const int maxDigits = 10;
	decimal rollOver;

	void Awake () {
		rollOver = (decimal) Math.Pow(_base, maxDigits-1);
	}

	public void OnButton(int digit) {
		if (value > rollOver) {
			Debug.Log ("old value: " + value);
			value = Decimal.Parse(value.ToString().Substring(1)) * _base + digit;
			Debug.Log ("new value: " + value);
		} else value = (value * _base) + digit;
		display.text = value.ToString();
	}

}
