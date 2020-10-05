using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript2 : MonoBehaviour
{
     InputManager inputManager;
 
    [SerializeField] float playerSpeed = 0f;

    [SerializeField] private Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    
    void Start () {

      if (MainCamera == null)
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

      /*if( PhotonView.Find(1003))
      {
        
      }
      */
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
    }
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }
 
    void Update ()
    {
        transform.Translate(inputManager.CurrentInput * Time.deltaTime * playerSpeed);

        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
        transform.position = viewPos;

    /*float horiz = Input.GetAxis ("Horizontal");
		transform.Translate (new Vector3 (horiz * playerSpeed2, 0, 0));
		if (transform.position.x < -15f) {
			transform.position = new Vector3 (-15f, transform.position.y, transform.position.z);
			Debug.Log ("Left edge of view");
		} else if (transform.position.x > 10f) {
			transform.position = new Vector3 (10f, transform.position.y, transform.position.z);
			Debug.Log ("Right edge of view");
		}

		this.transform.Translate (new Vector3 (h, 0.0f, 0.0f));
*/

    }
 
}
