using System.Collections;
using GameJolt.API;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityStandardAssets.CrossPlatformInput;

namespace GameJolt.Demo.UI {
	public class UserInfoBox : MonoBehaviour {

[SerializeField] private Text resulter2;
[SerializeField] private Text resulter;
[SerializeField] private Text P2Score;

private int scoreValue;
private int tableID = 543587;
  public string scr;

  int avtIndx;

 public GameObject otherobj;
	
private PhotonView myPV;
		public void Start() 
		{
            Text resulter = GameObject.FindWithTag("P1Name").GetComponent<Text>() as Text;
		 	Text resulter2 = GameObject.FindWithTag("P2Name").GetComponent<Text>() as Text;
		 	Text P2Score = GameObject.FindWithTag("P2ScoreVal").GetComponent<Text>() as Text;

			myPV = GetComponent<PhotonView>();


		 if(!myPV.IsMine)
		 {
			 (otherobj.GetComponent(scr) as MonoBehaviour).enabled = false; 
			 string key = "Player2";
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
			Text P2Score = GameObject.FindWithTag("P2ScoreVal").GetComponent<Text>() as Text;
			 if(!myPV.IsMine)
		 {
			
		
         }
		 if(myPV.IsMine)
		 {

			 if(P2Score.text == "9")
			 {
				 avtIndx = 5;
            	 PlayerPrefs.SetInt("Avatar", avtIndx);
             	 GameJolt.API.Trophies.Unlock(128827);
				 scoreValue++;
				 PlayerPrefs.SetInt("scoreP2",scoreValue);
				 scoreValue = PlayerPrefs.GetInt("scoreP2");

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