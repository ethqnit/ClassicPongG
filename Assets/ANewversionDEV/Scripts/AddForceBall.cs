using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceBall : MonoBehaviour
{     private Rigidbody2D fireballBody;
public GameObject Ball;
    public float speed;
    public TimerScript timerScript;
    public AudioSource audioSource;
    void Start()
    {
        fireballBody = Ball.gameObject.GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    public void ForceMult() 
    {
      audioSource.Play();
      timerScript.TimerReset();
      timerScript.TimerStart();
      fireballBody.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
    }
    public void ForceDiv() 
    {
      fireballBody.drag = 0.5f;
     
    }
}
   
