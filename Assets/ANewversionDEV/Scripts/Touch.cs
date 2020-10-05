using UnityEngine;
using System.Collections;
using System;

public class Touch : MonoBehaviour {
    internal readonly TouchPhase phase;
    public GameObject player;
	public ScriptableObject script;
    internal Vector2 position;



    // Use this for initialization
    void Start () {
		float ballSpeed = 200;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
		{
			Vector2 touchPosition = Input.GetTouch(0).position;
			double halfScreen = Screen.width / 2.0;

			
			//Check if it is left or right?
			if(touchPosition.x < halfScreen){
				player.transform.Translate(Vector3.up * 30 * Time.deltaTime);
				GetComponent<Rigidbody2D>().AddForce (new Vector2 (80, 10));
				GetComponent<Rigidbody2D>().GetPointVelocity (new Vector2 (80, 10));

			} else if (touchPosition.x > halfScreen) {
				player.transform.Translate(Vector3.down * 30 * Time.deltaTime);
				GetComponent<Rigidbody2D>().AddForce (new Vector2 (-80, -10));
				GetComponent<Rigidbody2D>().GetPointVelocity (new Vector2 (80, 10));


			}
			
		}
		
	}

    public static implicit operator Touch(UnityEngine.Touch v)
    {
        throw new NotImplementedException();
    }
}

