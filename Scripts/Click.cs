using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text gpc;
	public UnityEngine.UI.Text goldDisplay;
	public float gold = 0.00f;
	public int goldperclick = 1;

	void Update(){
		goldDisplay.text = "Gold : " + CurrencyConverter.Instance.GetCureencyIntoString(gold, false, false);
		gpc.text = CurrencyConverter.Instance.GetCureencyIntoString(goldperclick,false,true) + " Gold/Click";
	}

	public void Clicked(){
		gold += goldperclick;
	}

}