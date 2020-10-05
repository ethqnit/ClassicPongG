using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameJolt.UI;
using GameJolt.API;

public class ScoreWInner : MonoBehaviour
{
    
        public GameObject WinnerP1;
         public GameObject ScoreManager;
         public P1Goal P11;
        public Text P1;
        public Text String1;
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(P11.p == 10)
                {
                    /*
                      int scoreValue = 1; // The actual score.
            string scoreText = "Points"; // A string representing the score to be shown on the website.
            int tableID = 505969; // Set it to 0 for main highscore table.
            string extraData = ""; // This will not be shown on the website. You can store any information.
            GameJolt.API.Scores.Add(scoreValue, scoreText, tableID, extraData, (bool success) => {
            Debug.Log(string.Format("Score Add {0}.", success ? "Successful" : "Failed"));
            });
                    */
                     WinnerP1.gameObject.SetActive(true);
                     ScoreManager.gameObject.SetActive(true);
                     Time.timeScale = 0.01f;  
                }
                
    }
}
