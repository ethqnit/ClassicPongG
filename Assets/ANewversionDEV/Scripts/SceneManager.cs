using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
int buildIndex = 1;
public GameObject paused;
public GameObject resume;
  public static bool GameIsPaused = false;

    // Start is called before the first frame update
    
   public void SceneLoad()
   {
    UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
   }
   public void SceneLoadAvatar()
   {
    UnityEngine.SceneManagement.SceneManager.LoadScene("Avatar");
   }
    public void SceneLoadCredits()
   {
    UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
   }
    public void Back()
   {
    PhotonNetwork.Disconnect();
    Time.timeScale = 1.0f;
    UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
   }
    public void Paused()
    {
        Time.timeScale = 0.0f;
        GameIsPaused = true;
       resume.gameObject.SetActive(true);
    }
    public void Resume()
    {
         Time.timeScale = 1.0f;
         GameIsPaused = false;
         paused.gameObject.SetActive(true);
    }
    public void Clear()
    {
      PlayerPrefs.DeleteAll();
    }
    public void Quit()
    {
       Application.Quit();
    }
   
}
