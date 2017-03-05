using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Rigidbody ballBody;
	private AudioSource ballRollSound;
	//private bool soundShouldPlay = true;

	public float launchSpeed;

	// Use this for initialization
	void Start () {
		ballBody = GetComponent<Rigidbody>();
		ballRollSound = GetComponent<AudioSource>();
		ballBody.velocity = new Vector3(0,0,launchSpeed);
		ballRollSound.Play();
	}
}