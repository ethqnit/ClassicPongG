using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMuter : MonoBehaviour
{
     AudioSource audioSource;
      bool isMute;
    // Start is called before the first frame update
    public void Mute (){
     isMute = ! isMute;
     AudioListener.volume =  isMute ? 0 : 1;
 }
}
