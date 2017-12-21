using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// public variables show up as editable properties in Unity
	public float speed;

	// don't show up in the Unity as editable properties
	private Rigidbody rb;

	// runs once at the start of the game
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame/when rendering a frame
	// most game code goes here
	void Update () 
	{
		
	}

	// FixedUpdate is called just before doing physics calculations
	// physics code goes here
	void FixedUpdate () 
	{
		
		float moveHorizationtal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		// Vector3 (x ,y ,z)
		Vector3 movement = new Vector3 (moveHorizationtal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		Destroy(other.gameObject);
	}
}
