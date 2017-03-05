using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Ball))]
public class DragLaunch : MonoBehaviour {

	private Ball myBall;
	private Vector3 startPosition, endPosition;
	private float startTime, endTime;

	// Use this for initialization
	void Start () {
		myBall = GetComponent<Ball>();
	}

	public void DragStart(){
		startPosition = Input.mousePosition;
		startTime = Time.time;

	}

	public void DragEnd(){
		endPosition = Input.mousePosition;
		endTime = Time.time;
		//DeltaTime
		float deltaTime = endTime - startTime;
		// X to X but Y to Z for deltaLaunch
		float launchSpeedX = (endPosition.x - startPosition.x ) / deltaTime;
		float launchSpeedZ = (endPosition.y - startPosition.y) /deltaTime;
		//Launch Vector with Y translated to Z
		Vector3 deltaPosition = new Vector3 (launchSpeedX, 0, launchSpeedZ);
		myBall.Launch(deltaPosition);
	}
}
