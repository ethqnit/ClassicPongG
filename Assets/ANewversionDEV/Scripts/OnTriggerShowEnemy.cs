using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerShowEnemy : MonoBehaviour
{
    private Rigidbody2D fireballBody;
    public GameObject Ball;
    public float speed;
    public GameObject Boolean;
 //     public Button Power;
    public TimerEnemy timerScriptenemy2;
    public AudioSource audioSource; 
    public Text texting;

 void Start()
    {
        fireballBody = Ball.gameObject.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Ball"))
        {
    Boolean.gameObject.SetActive(true);
    if(Boolean.gameObject.activeSelf && texting.text.ToString() == "10")
    {

    fireballBody.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
      audioSource.Play();
    }
    }
    }
    
void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if(Boolean.gameObject.activeSelf && texting.text.ToString() == "10")
    {

    fireballBody.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
      audioSource.Play();
     timerScriptenemy2.TimerReset();
      timerScriptenemy2.TimerStart();
    }
    else{
 Boolean.gameObject.SetActive(false);
    
    }
   

        }
    }

}