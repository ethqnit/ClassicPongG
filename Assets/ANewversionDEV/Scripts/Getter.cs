using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameJolt.API;
using GameJolt.UI;

public class Getter : MonoBehaviour
{
  private GameObject gameObjectFoundBySearch;
    // Start is called before the first frame update
     
    void Start()
    {
       gameObjectFoundBySearch = GameObject.FindGameObjectWithTag("GameJolt");
          switch( PlayerPrefs.GetInt("Avatar"))
      {
          case 1:
           gameObjectFoundBySearch = GameObject.FindGameObjectWithTag("GameJolt");
          GameJolt.API.Trophies.Unlock(127443);
              break;
          case 2:
           gameObjectFoundBySearch = GameObject.FindGameObjectWithTag("GameJolt");
          GameJolt.API.Trophies.Unlock(127444);
              break;
          case 3:
           gameObjectFoundBySearch = GameObject.FindGameObjectWithTag("GameJolt");
          GameJolt.API.Trophies.Unlock(127446);
          break;
          default:
          break;
      }
    }

    public void ShowLeaderboards() 
        {
			GameJoltUI.Instance.ShowLeaderboards();
			// if you only want to show certain tables, you can provide them as additional arguments:
			// GameJolt.UI.Manager.Instance.ShowLeaderboards(null, null, 123, 456, 789, ...);
		}
    public void Trophy()
    {
      GameJoltUI.Instance.ShowTrophies();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
