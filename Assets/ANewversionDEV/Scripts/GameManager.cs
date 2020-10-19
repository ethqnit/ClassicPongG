using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PlayerScore1 = 0;
    public int PlayerScore2 = 0;
    public Text P1;
    public Text P2;
    public int index;
    public int avtIndx;
    public GameObject Wall1;
    public GameObject Wall2;
    public float smoothing = 1f;
    public Transform target;
    public AudioSource P1audioSource;
    public AudioSource P2audioSource;
    public BallControl Script;
    public EnemyFollowScript EMF;
    //public EnemyFollowScript ENF;
    public TopDown topDown;
    public GameObject Winner1;
    public GameObject Winner2;
    public P2Colorchanger Colorchanger;
    public GameObject L1,L2,L3,L4,L5,L6,L7,L8,L9,L10;
    
    void Start()
    {
        
        index = PlayerPrefs.GetInt("Level");
        avtIndx = PlayerPrefs.GetInt("Avatar");

         switch (PlayerPrefs.GetInt("Avatar"))
      {
          case 1:
          topDown.moveSpeed = 850;
              break;
          case 2:
          topDown.moveSpeed = 900;
              break;
          case 3:
          topDown.moveSpeed = 1000;
              break;
           case 4:
          topDown.moveSpeed = 1500;
              break;
           case 5:
          topDown.moveSpeed = 1600;
              break;
           case 6:
          topDown.moveSpeed = 1800;
              break;

                default:
             
              break;
      }

        if(avtIndx == 1)
        {

        }

        Time.timeScale = 0.0f;


        switch (PlayerPrefs.GetInt("Level"))
      {
          case 1:
          Colorchanger.One();
           Script.str = 0.06f;
           Script.str2 = 0.05f;
         EMF.VitesseEnnemi = 400;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(true);//Set
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
             Time.timeScale = 0.0f;
              break;
          case 2:
          Colorchanger.Two();
            Script.str = 0.065f;
            Script.str2 = 0.055f;
           EMF.VitesseEnnemi = 450;
             L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(true);//Set
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
             Time.timeScale = 0.0f;
              break;
          case 3:
            Colorchanger.Three();
           avtIndx = 1;
          PlayerPrefs.SetInt("Avatar", avtIndx);
          Script.str = 0.075f;
            Script.str2 = 0.058f;
            EMF.VitesseEnnemi = 500;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(true);//Set
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
           Time.timeScale = 0.0f;
              break;
          case 4:
          avtIndx = 2;
          PlayerPrefs.SetInt("Avatar", avtIndx);
          Colorchanger.Four();
           Script.str = 0.075f;
            Script.str2 = 0.060f;
          EMF.VitesseEnnemi = 550;
            L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false); 
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(true);//Set
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
            Time.timeScale = 0.0f;
              break;
          case 5:
          avtIndx = 3;
          PlayerPrefs.SetInt("Avatar", avtIndx);
          Colorchanger.Five();
           Script.str = 0.080f;
            Script.str2 = 0.070f;
          EMF.VitesseEnnemi = 600;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(true);//Set
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
          Time.timeScale = 0.0f;
              break;
          case 6:
            Colorchanger.Six();
           Script.str = 0.080f;
            Script.str2 = 0.075f;
           EMF.VitesseEnnemi = 650;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(true);//Set
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
             Time.timeScale = 0.0f;
              break;
          case 7:
            Colorchanger.Seven();
           Script.str = 0.090f;
            Script.str2 = 0.075f;
           EMF.VitesseEnnemi = 700;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(true);//Set
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
            Time.timeScale = 0.0f;
              break;
          case 8:
            Colorchanger.Eight();
           Script.str = 0.090f;
            Script.str2 = 0.080f;
          EMF.VitesseEnnemi = 750;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(true);//Set
            Time.timeScale = 0.0f;
              break;
          case 9:
            Colorchanger.Nine();
          EMF.VitesseEnnemi = 800;
           Script.str = 0.090f;
            Script.str2 = 0.085f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(true);//Set
          Time.timeScale = 0.0f;
              break;
          case 10:
          Colorchanger.Ten();
        EMF.VitesseEnnemi = 850;
          avtIndx = 4;
          PlayerPrefs.SetInt("Avatar", avtIndx);
          Script.str = 0.095f;
            Script.str2 = 0.085f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
            Time.timeScale = 0.0f;
              break;
          default:
             
              break;
      }
    }
   
 IEnumerator MyCoroutine (Transform target)
    {
        while(Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
            yield return null;
        }
    yield return new WaitForSeconds(3f);
    }
  
     void OnCollisionEnter2D(Collision2D col)
    {
         if (col.gameObject.CompareTag("Wall1"))
        {
            PlayerScore1++;
            P1.text = PlayerScore1.ToString();
            Script.RestartGame();
            P1audioSource.Play();
             StartCoroutine(MyCoroutine(target));
             
        }
         if (col.gameObject.CompareTag("Wall2"))
       {
            PlayerScore2++;
            P2.text = PlayerScore2.ToString();
            Script.RestartGame();
             P2audioSource.Play();
            StartCoroutine(MyCoroutine(target));
       }
     
    }



private void LevelWait()
{
	StartCoroutine(Wait());
}

IEnumerator Wait()
{
	//To wait, type this:
  
  	Winner1.gameObject.SetActive(true);
    Time.timeScale = 0.4f;
	yield return new WaitForSeconds(2f);
     UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    //Stuff after waiting

}

    void Update()
    {
        if(PlayerScore1.ToString() == "10")
       {
            index++;
            
            Winner1.gameObject.SetActive(true);
            PlayerScore1 = 0;
            PlayerScore2 = 0;
             PlayerPrefs.SetInt("Level", index);
             PlayerPrefs.SetInt("Avatar", avtIndx);

            if(index >= 10)
            {
                index = 10;
            }

        switch (PlayerPrefs.GetInt("Level"))
      {
          case 1:
           //Time.timeScale = 0.0f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(true);//Set
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
                StartCoroutine(Wait());

              break;
          case 2:
           //Time.timeScale = 0.0f;
             L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(true);//Set
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
            StartCoroutine(Wait());
               
              break;
          case 3:
          avtIndx = 1;
          PlayerPrefs.SetInt("Avatar", avtIndx);
           GameJolt.API.Trophies.Unlock(127443);
           //Time.timeScale = 0.0f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(true);//Set
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
            StartCoroutine(Wait());
                
              break;
          case 4:
          // Time.timeScale = 0.0f;
           avtIndx = 2;
          PlayerPrefs.SetInt("Avatar", avtIndx);
           GameJolt.API.Trophies.Unlock(127444);
            L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false); 
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(true);//Set
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
             StartCoroutine(Wait());
              
              break;
          case 5:
           //Time.timeScale = 0.0f;
           avtIndx = 3;
           PlayerPrefs.SetInt("Avatar", avtIndx);
            GameJolt.API.Trophies.Unlock(127446);
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(true);//Set
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
              StartCoroutine(Wait());
                
              break;
          case 6:
           //Time.timeScale = 0.0f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(true);//Set
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
             StartCoroutine(Wait());
                
              break;
          case 7:
          avtIndx = 2;
            PlayerPrefs.SetInt("Avatar", avtIndx);
             GameJolt.API.Trophies.Unlock(127444);
           //Time.timeScale = 0.0f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(true);//Set
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(false);
            StartCoroutine(Wait());
                
              break;
          case 8:
           //Time.timeScale = 0.0f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(true);//Set
                       L10.gameObject.SetActive(false); 
             StartCoroutine(Wait());
                
              break;
          case 9:
           //Time.timeScale = 0.0f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(true);//Set
             StartCoroutine(Wait());
               
              break;
          case 10:
           avtIndx = 3;
            PlayerPrefs.SetInt("Avatar", avtIndx);
             GameJolt.API.Trophies.Unlock(128824);
           //Time.timeScale = 0.0f;
              L1.gameObject.SetActive(false);
               L2.gameObject.SetActive(false);
                L3.gameObject.SetActive(false);
                 L4.gameObject.SetActive(false);
                  L5.gameObject.SetActive(false);
                   L6.gameObject.SetActive(false);
                    L7.gameObject.SetActive(false);
                     L8.gameObject.SetActive(false);
                      L9.gameObject.SetActive(false);
                       L10.gameObject.SetActive(true);//Set
              LevelWait();
               
              break;
          default:
             
              break;
      }
       }

        if(PlayerScore2.ToString() == "10")
       {
            Time.timeScale = 0.0f;
            Winner2.gameObject.SetActive(true);
       }
    
    }
}