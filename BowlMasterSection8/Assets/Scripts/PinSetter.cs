using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour {

	private Pin[] isPinStanding;
	public Text standingDisplay;

	// Use this for initialization
	void Start () {
		isPinStanding = FindObjectsOfType<Pin>();
	}

	void Update () {
		standingDisplay.text = CountStanding().ToString();
	}

int CountStanding(){
	int standing = 0;

	foreach(Pin pin in isPinStanding){
			if(pin.isStanding()){
				standing++;
			}
		}
		return standing;
	}
}
