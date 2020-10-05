using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TopDownMultiplayer2 : MonoBehaviour {

	// Variables to hold Input directions in X and Y axses
	float dirX, dirY;

	// Move speed variable can be set in Inspector with slider
	[Range(1f, 800f)]
	public float moveSpeed = 5f;

    [SerializeField] private GameObject Stopper1, Refresher, Refresher2, Refresher3;
	// Update is called once per frame
	void Update () {
		Stopper1 = GameObject.Find("U");
        Refresher = GameObject.Find("R");
        Refresher2 = GameObject.Find("D");
        Refresher3 = GameObject.Find("L");
		// Getting move direction according to button pressed
		// multiplied by move speed and time passed
		dirX = CrossPlatformInputManager.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
		dirY = CrossPlatformInputManager.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;

		// Setting new transform position of game object
		transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
	}
	
}