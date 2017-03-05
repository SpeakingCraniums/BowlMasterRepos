using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody ballBody;
	private AudioSource ballRollSound;
	private Vector3 testVelocity;

	public float launchSpeed;

	// Use this for initialization
	void Start () {
		testVelocity = new Vector3 (0,0,100);
		ballBody = GetComponent<Rigidbody>();
		ballRollSound = GetComponent<AudioSource>();
		ballBody.useGravity = false;
		Launch (testVelocity);
	}

	public Launch(Vector3 velocity)
	{
		velocity = testVelocity
		ballRollSound.Play ();
		ballBody.velocity
	}
}