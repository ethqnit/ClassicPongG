using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowScript : MonoBehaviour 
{// Adjust the speed for the application.  public GameObject objectToFollow;

     public Transform Ball;
     public Transform Player;
     public GameObject Returner;
     public GameObject P2Limit;
     public GameObject P2Limit2;

    public float VitesseEnnemi;

    public float distance;
    
    void Start()
    {
         if(P2Limit.gameObject.activeSelf)
        {
             transform.position = Vector2.MoveTowards(transform.position, Ball.transform.position, VitesseEnnemi * Time.deltaTime);  
        }
    }
    
    void Update()
    {
     distance = Vector3.Distance (Ball.transform.position, Player.transform.position);

        if(P2Limit.gameObject.activeSelf == true)
        {
            if(distance <= 500)
            {
             transform.position = Vector2.MoveTowards(transform.position, Ball.transform.position, VitesseEnnemi * Time.deltaTime);  
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, Returner.transform.position, VitesseEnnemi * Time.deltaTime);
            }
        }
        if(P2Limit.gameObject.activeSelf == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, Returner.transform.position, VitesseEnnemi * Time.deltaTime);
        }
    }
       void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Stopper2"))
        {
            P2Limit.gameObject.SetActive(false);
            P2Limit2.gameObject.SetActive(true);
        }
         if (other.gameObject.CompareTag("Stopper22"))
        {
            P2Limit.gameObject.SetActive(true);
            P2Limit2.gameObject.SetActive(false);
        }
    }
   

}
