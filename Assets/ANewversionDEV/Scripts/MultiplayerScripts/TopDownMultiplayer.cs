using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.API;
using GameJolt.UI;
using UnityEngine.UI;
using Photon.Pun;
using UnityStandardAssets.CrossPlatformInput;

public class TopDownMultiplayer : MonoBehaviour {

	private PhotonView myPV;
	// Variables to hold Input directions in X and Y axses
	float dirX, dirY;

	// Move speed variable can be set in Inspector with slider
	[Range(1f, 800f)]
	public float moveSpeed = 5f;

	void Start()
	{
		myPV = GetComponent<PhotonView>();

		    switch (PlayerPrefs.GetInt("Avatar"))
      {
          case 1:
          moveSpeed = 7f;
              break;
          case 2:
         moveSpeed = 10f;
              break;
          case 3:
          moveSpeed = 12f;
              break;
           case 4:
         moveSpeed = 15f;
              break;
           case 5:
         moveSpeed = 7.0f;
              break;
           case 6:
        moveSpeed = 7.0f;
              break;

                default:
             
              break;
      }

	}
    [SerializeField] private GameObject Stopper1, Refresher, Refresher2, Refresher3;
	// Update is called once per frame
	void Update ()
	 {
		 if(myPV.IsMine)
		 {
		Stopper1 = GameObject.Find("Up");
        Refresher = GameObject.Find("Right");
        Refresher2 = GameObject.Find("Down");
        Refresher3 = GameObject.Find("Left");
		// Getting move direction according to button pressed
		// multiplied by move speed and time passed
		dirX = CrossPlatformInputManager.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
		dirY = CrossPlatformInputManager.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;

		// Setting new transform position of game object
	
		 }
		 	transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
		
	}
	
}