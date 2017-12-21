using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	// public variables show up as editable properties in Unity
	public float speed;
	public Text countText;
	public Text winText;

	// don't show up in the Unity as editable properties
	private Rigidbody rb;

	private int count;

	// runs once at the start of the game
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();	
		winText.text = "";
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

	// deactivate pick up object on collision
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= 12)
		{
			winText.text = "You win!";
		}
	}
}
