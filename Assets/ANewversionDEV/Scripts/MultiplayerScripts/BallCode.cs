using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class BallCode : MonoBehaviour
{/*

     
    float velx = 0.6f;
    float vely = 0.1f;
    Vector3 pos;

    void Start()
    {
        pos = new Vector3(0, 0, -1);
    }

    void Update()
    {
        transform.position += new Vector3(pos.x + velx, pos.y + vely, 0);
    }

    public  void OnCollisionEnter2D(Collision2D col)
    {
        velx *= (-1);
    }
    */

 public PhotonView pv;
     private Rigidbody2D rb2d;
    public float str = 0.05f;
    public float str2 = 0.05f;
    // Start is called before the first frame update
    public PhysicsMaterial2D  bouncy;
   [SerializeField] private AudioSource audioSource;
  
    void Start () 
    {  
         rb2d = GetComponent<Rigidbody2D>();
        audioSource = GameObject.FindGameObjectWithTag("MultiplayerAudio").GetComponent<AudioSource>();

       if (pv.IsMine)
       {
     rb2d = GetComponent<Rigidbody2D>();
     Invoke("GoBall", 2);
       }

    }

     void GoBall()
    {
        
    float rand = Random.Range(0, 2);
    if(rand < 1)
     {
        rb2d.AddForce(new Vector2(1000, -40));
     } 
     else 
     {
        rb2d.AddForce(new Vector2(-1000, -40));
     }
    }
     void OnCollisionEnter2D (Collision2D coll) 
    {
     if(coll.collider.CompareTag("Player"))
     {
         audioSource.Play();
        rb2d.AddForce(rb2d.velocity * str, ForceMode2D.Impulse);
	    //audioSource.Play();
        Vector2 vel;
        vel.x = rb2d.velocity.x;
        vel.y = (rb2d.velocity.y / 1) + (coll.collider.attachedRigidbody.velocity.y / 2);
        rb2d.velocity = vel;
    }
     if(coll.collider.CompareTag("Player2"))
     {
        audioSource.Play();
        rb2d.AddForce(rb2d.velocity * str, ForceMode2D.Impulse);
	    //audioSource.Play();
        Vector2 vel;
        vel.x = rb2d.velocity.x;
        vel.y = (rb2d.velocity.y / 1) + (coll.collider.attachedRigidbody.velocity.y / 2);
        rb2d.velocity = vel;
    }
      
    }
}