using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWinner2 : MonoBehaviour
{
    public GameObject WinnerP2;
    public GameObject ScoreManager;
    public P2Goal P22;
    public Text P2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(P22.p == 10)
                {
                     
                     WinnerP2.gameObject.SetActive(true);
                     ScoreManager.gameObject.SetActive(true);
                     Time.timeScale = 0.01f;      
                }

                
    }
}
