using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersPref : MonoBehaviour
{
    public int prefvalue;
    // Start is called before the first frame update
    void Start()
    {
          prefvalue = PlayerPrefs.GetInt("Level");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
