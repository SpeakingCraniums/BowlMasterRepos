using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody ballBody;
	private AudioSource ballRollSound;

	public Vector3 launchVelocity;

	// Use this for initialization
	void Start () {
		ballBody = GetComponent<Rigidbody>();
		ballRollSound = GetComponent<AudioSource>();
		ballBody.useGravity = false;
		//Launch (launchVelocity);
	}

	public void Launch (Vector3 velocity)
	{
		ballBody.useGravity = true;
		ballBody.velocity = velocity;
		ballRollSound.Play ();
	}
}