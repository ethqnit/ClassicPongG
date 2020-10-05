using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class P2Colorchanger : MonoBehaviour
{
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
         image = GetComponent<Image>();

    }

    // Update is called once per frame
    public void One()
    {
         GetComponent<Image>().color = new Color32(50,205,50,100);
    } 
     public void Two()
    {
         GetComponent<Image>().color = new Color32(0,0,255,100);
    }
     public void Three()
    {
         GetComponent<Image>().color = new Color32(138,43,226,100);
    }
     public void Four()
    {
        GetComponent<Image>().color = new Color32(210,105,30,100);
    }
    public void Five()
    {
         GetComponent<Image>().color = new Color32(255,69,0,100);
    }
    public void Six()
    {
         GetComponent<Image>().color = new Color32(255,255,0,100);
    }
     public void Seven()
    {
         GetComponent<Image>().color = new Color32(0,204,225,100);
    }
    public void Eight()
    {
         GetComponent<Image>().color = new Color32(255,0,0,100);
    }
    public void Nine()
    {
         GetComponent<Image>().color = new Color32(255,255,225,100);
    }
     public void Ten()
    {
         GetComponent<Image>().color = new Color32(192,192,192,100);
    }
}

