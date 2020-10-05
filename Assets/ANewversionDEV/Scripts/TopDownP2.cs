using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TopDownP2 : MonoBehaviour {

	// Variables to hold Input directions in X and Y axses
	float dirX, dirY;

	// Move speed variable can be set in Inspector with slider
	[Range(1f, 800f)]
	public float moveSpeed = 5f;
		public GameObject Stopper1;
		public GameObject Refresher;
		public GameObject Refresher2;
		public GameObject Refresher3;
	// Update is called once per frame
	void Update () {

		// Getting move direction according to button pressed
		// multiplied by move speed and time passed
		dirX = CrossPlatformInputManager.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
		dirY = CrossPlatformInputManager.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;

		// Setting new transform position of game object
		transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
	}
	void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Stopper2"))
        {
			Stopper1.gameObject.SetActive(false);

			Refresher.gameObject.SetActive(false);
			Refresher2.gameObject.SetActive(false);
			Refresher3.gameObject.SetActive(false);

			Refresher.gameObject.SetActive(true);
			Refresher2.gameObject.SetActive(true);
			Refresher3.gameObject.SetActive(true);
		}
		
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Stopper2"))
		{
		    Stopper1.gameObject.SetActive(true);
		}
	}
}