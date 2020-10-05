using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PVController : MonoBehaviour
{
    [SerializeField] private GameObject Controller1;

    [SerializeField] private GameObject Controller2;
    

    // Start is called before the first frame update
    void Start()
    {
        
      Controller1 = GameObject.FindGameObjectWithTag("Controller1");
      Controller2 = GameObject.FindGameObjectWithTag("Controller2");
      Controller2.gameObject.SetActive(true); Controller1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      Controller1 = GameObject.FindGameObjectWithTag("Controller1");
      Controller2 = GameObject.FindGameObjectWithTag("Controller2");
        
        if(PhotonView.Find(1001))
       {
           
                     Controller1.gameObject.SetActive(true);
           
       }
       else
       {
           
            Controller2.gameObject.SetActive(true);
       }
      
    }
}
