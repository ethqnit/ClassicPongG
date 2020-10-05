using GameJolt.API;
using GameJolt.UI;
using UnityEngine;
using UnityEngine.UI;

namespace GameJolt.Demo.Load {
	public class LoadTest : MonoBehaviour 
	{
		public GameObject Lock, LoadScene, Multiplayer;
		public Button Activate;
		public void SignInButtonClicked() 
		{
		if(GameJoltAPI.Instance.CurrentUser == null)
		  {
			GameJoltUI.Instance.ShowSignIn((bool success) =>  {
			 
			if(success)
			{
					LoadScene.gameObject.SetActive(true);
				  Multiplayer.gameObject.SetActive(false);
			}
			else
			{
				LoadScene.gameObject.SetActive(false);
			Multiplayer.gameObject.SetActive(true);
			}

		  });
		}
	}
		public void SignOutButtonClicked() {
			if(!GameJoltAPI.Instance.HasUser) {
				GameJoltUI.Instance.QueueNotification("You're not signed in");
			} else {
				GameJoltAPI.Instance.CurrentUser.SignOut();
				GameJoltUI.Instance.QueueNotification("Signed out :(");
				LoadScene.gameObject.SetActive(false);
				Multiplayer.gameObject.SetActive(true);
			}
		}

		public void IsSignedInButtonClicked()
		 {
			if(GameJoltAPI.Instance.HasUser) 
			{
				
					 Activate.interactable = true;
					 Lock.gameObject.SetActive(false);
					 LoadScene.gameObject.SetActive(true);
					 Multiplayer.gameObject.SetActive(false);
			} else {
				GameJoltUI.Instance.QueueNotification("Not Signed In :(");
				Activate.interactable = false;
				LoadScene.gameObject.SetActive(false);
				Lock.gameObject.SetActive(true);
				Multiplayer.gameObject.SetActive(true);
			}
		}

		public void LoadSceneButtonClicked(string sceneName) {
			Debug.Log("Loading Scene " + sceneName);
			UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
		}
	}
}
