using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AvatarIndex : MonoBehaviour
{
    public int avatarIndex;
    public Text Unlocked;
    // Start is called before the first frame update
    void Start()
    {
          avatarIndex = PlayerPrefs.GetInt("Avatar");
          Unlocked.text = "Unlocked: " + avatarIndex.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
