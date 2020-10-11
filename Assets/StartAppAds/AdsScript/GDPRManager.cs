using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StartApp;

public class GDPRManager : MonoBehaviour
{
  public int index;
 public GameObject Manager;
    void Start()
    {
    
        index = PlayerPrefs.GetInt("index");

        if(index ==2)
        {
            Manager.gameObject.SetActive(false);

        }
        if(index == 3)
        {
            Manager.gameObject.SetActive(false);
        }

    }

    public void Concent()
    {
        AdSdk.Instance.SetUserConsent( "pas", true, (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);

        index = 2;
        PlayerPrefs.SetInt("index", index);
    }
    public void NotConcent()
    {
        AdSdk.Instance.SetUserConsent( "pas", false, (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds);
         index = 3;
         PlayerPrefs.SetInt("index", index);
    }

    // Update is called once per frame
    void Update()
    {
        if(index ==2)
        {
            Manager.gameObject.SetActive(false);

        }
        if(index == 3)
        {
            Manager.gameObject.SetActive(false);
        }
    }
}
