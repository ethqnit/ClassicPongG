using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;


public class P2Goal : MonoBehaviourPunCallbacks
{
    public GameObject Ball;
    public GameObject Player1;
    public GameObject Player2;
    public Text P2;
    public int p;
    [SerializeField] private AudioSource audioSource;
  
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("GoalSound").GetComponent<AudioSource>();

     P2.text = p++.ToString();
     Ball.GetComponent<Collider2D>();
     Time.timeScale = 1.0f;
    }

    IEnumerator func() {
  yield return new WaitForSecondsRealtime(0.2f); //Wait 1 second
   PhotonNetwork.Destroy(GameObject.Find("Ball 1(Clone)"));
}


   

    // Update is called once per frame
    
        void OnTriggerEnter2D(Collider2D other)
        {
               if (other.gameObject.CompareTag("Ball")) 
                {
                      if (PhotonNetwork.IsMasterClient)
                        {
                           if(GameObject.Find("Ball 1(Clone)"))
                            audioSource.Play();
                            StartCoroutine("func");
                             PhotonNetwork.Instantiate(Ball.name, new Vector3(0,0,-1), transform.rotation,0);
                        }   
                        P2.text = p++.ToString();
                }
            
        }
     
    
}
