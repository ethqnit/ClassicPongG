
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class AverageFectch : MonoBehaviour
{
    public Button Trophy1, Trophy2, Trophy3, Trophy4, Trophy5, Trophy6, Trophy7, Trophy8;
    // Start is called before the first frame update
    void Start()
    {
          switch (PlayerPrefs.GetInt("Avatar"))
      {
              case 1:
                Trophy1.interactable = true;
              break;

              case 2:
                Trophy1.interactable = true;
                Trophy2.interactable = true;
              break;

              case 3:
               Trophy1.interactable = true;
               Trophy2.interactable = true;
               Trophy3.interactable = true;
              break;

              case 4:
               Trophy1.interactable = true;
               Trophy2.interactable = true;
               Trophy3.interactable = true;
               Trophy4.interactable = true;
              break;
               case 5:
               Trophy1.interactable = true;
               Trophy2.interactable = true;
               Trophy3.interactable = true;
               Trophy4.interactable = true;
               Trophy5.interactable = true;
              break;
               case 6:
               Trophy1.interactable = true;
               Trophy2.interactable = true;
               Trophy3.interactable = true;
               Trophy4.interactable = true;
               Trophy5.interactable = true;
               Trophy6.interactable = true;
              break;
               case 7:
               Trophy1.interactable = true;
               Trophy2.interactable = true;
               Trophy3.interactable = true;
               Trophy4.interactable = true;
               Trophy5.interactable = true;
               Trophy6.interactable = true;
               Trophy7.interactable = true;
              break;
               case 8:
               Trophy1.interactable = true;
               Trophy2.interactable = true;
               Trophy3.interactable = true;
               Trophy4.interactable = true;
               Trophy5.interactable = true;
               Trophy6.interactable = true;
               Trophy7.interactable = true;
               Trophy8.interactable = true;
              break;

              default:
               Trophy1.interactable = false;
               Trophy2.interactable = false;
               Trophy3.interactable = false;
               Trophy4.interactable = false;
               Trophy5.interactable = false;
               Trophy6.interactable = false;
               Trophy7.interactable = false;
               Trophy8.interactable = false;
              break;
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
