using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	public float standingThreshold;

	// Use this for initialization
	void Start () {
		standingThreshold = 5f; 
	}
	// Update is called once per frame
	void Update () {
		isStanding();
	}
	public bool isStanding(){
		Vector3 rotationInEuler = transform.rotation.eulerAngles;
		float tiltInX = Mathf.Abs(rotationInEuler.x);
		float tiltInZ = Mathf.Abs(rotationInEuler.z);
		if (tiltInX < standingThreshold && tiltInZ<standingThreshold){
			return true;
		}else {
			return false;
		}

	}
}
