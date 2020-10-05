using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour 
{
    private Rigidbody2D rb2d;
    public float str = 0.05f;
    public float str2 = 0.05f;
    // Start is called before the first frame update
    public PhysicsMaterial2D  bouncy;
     public AudioSource audioSource;
  
    void Start () 
    {
        
    rb2d = GetComponent<Rigidbody2D>();
    Invoke("GoBall", 2);
    }
    public void ChangerSTR1()
    {
        float str;
        float strs;
    }

     void GoBall()
    {
    float rand = Random.Range(0, 2);
    if(rand < 1)
    {
        rb2d.velocity = Vector2.zero;
        rb2d.AddForce(new Vector2(1900, -100));
    } else 
    {
        rb2d.velocity = Vector2.zero;
        rb2d.AddForce(new Vector2(-1900, -100));
    }
    }

    void ResetBall()
    {
    rb2d.velocity = Vector2.zero;
    transform.position = Vector2.zero;
    }

    public void RestartGame()
    {
    ResetBall();
    Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D (Collision2D coll) 
    {
     if(coll.collider.CompareTag("Player1"))
     {
         rb2d.AddForce(rb2d.velocity * str, ForceMode2D.Impulse);

	    audioSource.Play();
        Vector2 vel;
        vel.x = rb2d.velocity.x;
        vel.y = (rb2d.velocity.y / 1) + (coll.collider.attachedRigidbody.velocity.y / 2);
        rb2d.velocity = vel;
    }
      if(coll.collider.CompareTag("Player2"))
      {
      rb2d.AddForce(rb2d.velocity * str2, ForceMode2D.Impulse);
        audioSource.Play();
        Vector2 vel2;
        vel2.x = rb2d.velocity.x;
        vel2.y = (rb2d.velocity.y / 1) + (coll.collider.attachedRigidbody.velocity.y / 2);
        rb2d.velocity = vel2;
        }  
    }

    // Update is called once per frame
    void Update()
    {
      
      

    }
    
}
