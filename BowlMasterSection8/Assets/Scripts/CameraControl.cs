using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Ball bowlingBall;

	private Vector3 cameraOffset;

	// Use this for initialization
	void Start () {
		cameraOffset = transform.position - bowlingBall.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.z <= 1829f){
			transform.position = bowlingBall.transform.position + cameraOffset;
		}
	}
}
