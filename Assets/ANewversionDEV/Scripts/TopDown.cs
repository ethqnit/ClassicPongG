using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TopDown : MonoBehaviour {

	// Variables to hold Input directions in X and Y axses
	float dirX, dirY;

	// Move speed variable can be set in Inspector with slider
	[Range(1f, 2000f)]
	public float moveSpeed = 5f;
	      [SerializeField] public GameObject Stopper1;
		  [SerializeField] public GameObject Refresher;
		  [SerializeField] public GameObject Refresher2;
		  [SerializeField] public GameObject Refresher3;
	// Update is called once per frame
	void Start()
	{
		//Stopper1 = GameObject.FindWithTag("Stopper1") ;
		//Refresher = GameObject.FindWithTag("Up") ;
		//Refresher2 = GameObject.FindWithTag("Down") ;
		//Refresher3 = GameObject.FindWithTag("Left") ;
		//WE need to keep making other calls sto start for the UP, Down, Left, Right Buttons private like Stopper1 upon start.

		// Note the variables are private and the serialized field is being used to show it on the editor.
	}
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
        if (other.gameObject.CompareTag("Stopper1"))
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
		if (other.gameObject.CompareTag("Stopper1"))
		{
		    Stopper1.gameObject.SetActive(true);
		}
	}
}