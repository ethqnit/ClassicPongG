using System.Collections;
using GameJolt.API;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityStandardAssets.CrossPlatformInput;

namespace GameJolt.Demo.UI {
	public class UserInfoBox2 : MonoBehaviour {

[SerializeField] private Text resulter2;
 [SerializeField] private Text resulter;
 [SerializeField] private Text P1Score;
 int  avtIndx;
 
 private int scoreValue; // The actual score.

 public string scr;

 private int tableID = 543587;

 public GameObject otherobj;
	
private PhotonView myPV;
		public void Start() 
		{
            Text resulter = GameObject.FindWithTag("P1Name").GetComponent<Text>() as Text;
		 	Text resulter2 = GameObject.FindWithTag("P2Name").GetComponent<Text>() as Text;
			Text P1Score = GameObject.FindWithTag("P1ScoreVal").GetComponent<Text>() as Text;
			myPV = GetComponent<PhotonView>();


		 if(!myPV.IsMine)
		 {
			 string key = "Player2";
			 (otherobj.GetComponent(scr) as MonoBehaviour).enabled = false; 
			 bool isGlobal = true;
			 GameJolt.API.DataStore.Get(key, isGlobal, (string value) => {
    			if (value != null)
    			{
       			 resulter2.text = value;
   			 }
			});
		
         }
		 if(myPV.IsMine)
		 {

			 (otherobj.GetComponent(scr) as MonoBehaviour).enabled = true; 
			 string key = "Player1";
			 bool isGlobal = true;
			 GameJolt.API.DataStore.Get(key, isGlobal, (string value) => {
    			if (value != null)
    			{
       			 resulter.text = value;
   			 }
			});
			 
		}

	}
	void Update()
	{
			Text P1Score = GameObject.FindWithTag("P1ScoreVal").GetComponent<Text>() as Text;
			 if(!myPV.IsMine)
		 {
			
		
         }
		 if(myPV.IsMine)
		 {
			 if(P1Score.text == "9")
			 {
				 avtIndx = 4;
            	 PlayerPrefs.SetInt("Avatar", avtIndx);
             	 GameJolt.API.Trophies.Unlock(128826);
				 scoreValue++;
				 PlayerPrefs.SetInt("scoreP1",scoreValue);
				 scoreValue = PlayerPrefs.GetInt("scoreP1");
				
				 string scoreText = "Won"; // A string representing the score to be shown on the website.
				 // Set it to 0 for main highscore table.
				 string extraData = ""; // This will not be shown on the website. You can store any information.
				 GameJolt.API.Scores.Add(scoreValue, scoreText, tableID, extraData, (bool success) => {
    			 Debug.Log(string.Format("Score Add {0}.", success ? "Successful" : "Failed"));
				 });

				 Time.timeScale = 0.001f;
				
			 } 
			 
		}
	}
}
}