using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class SpinningObjectsRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
        
float y = 1;
void Update () 
    {
        y -= Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(0,0,y);
    }
}
