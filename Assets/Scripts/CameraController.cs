using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame
	// waits for update to be called before running
	// use this to make sure the player's move is done b4 running the code below
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
