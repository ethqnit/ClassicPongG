using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OntriggerShow : MonoBehaviour
{
      [SerializeField] public GameObject Boolean;
      [SerializeField] public Button Power;

    void Start()
      {
       // Boolean = GameObject.FindWithTag("Boolean");
        Boolean.gameObject.SetActive(true);
		//Power = GameObject.FindWithTag("Power").GetComponent<Button>();
      }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Ball"))
        {
     Boolean.gameObject.SetActive(true);
     Power.interactable = true;

        }
     if (other.gameObject.CompareTag("Stopper2"))
        {
    
        }
    }
void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Ball"))
        {
    Boolean.gameObject.SetActive(false);
     Power.interactable = false;

        }
    }

}
