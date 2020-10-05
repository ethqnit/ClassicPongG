using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
 public GameObject otherobj; //your other object 
 public string scr;
 // your second script name 
 public string scr2;
 // your second script name 


 void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Stopper2"))
        {
             (otherobj.GetComponent(scr) as MonoBehaviour).enabled = false;
              (otherobj.GetComponent(scr2) as MonoBehaviour).enabled = true; 
        }
    }
     void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Stopper2"))
        {
             (otherobj.GetComponent(scr) as MonoBehaviour).enabled = true; 
             (otherobj.GetComponent(scr2) as MonoBehaviour).enabled = false; 
        }
    }

}
