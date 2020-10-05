using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{

public Image CurrentAvatar;
public SpriteRenderer CAM;
public Sprite Trophy, Trophy1, Trophy2, Trophy3, Trophy4, Trophy5, Trophy6, Trophy7, Trophy8;
public int CavatarIndex;

void Start()
{
    CavatarIndex = PlayerPrefs.GetInt("CurrentAvatar");
  
}
public void Trophy00()
{
 CavatarIndex = 0;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy;
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy;
 //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
}
public void Trophy11()
{
 CavatarIndex = 1;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy1;
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy1;
 //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
}
public void Trophy22()
{
 CavatarIndex = 2;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy2; //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy2;
}
public void Trophy33()
{
 CavatarIndex = 3;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy3; //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy3;
}
public void Trophy44()
{
 CavatarIndex = 4;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy4; //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy4;
}
public void Trophy55()
{
 CavatarIndex = 5;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy5; //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy5;
}
public void Trophy66()
{
 CavatarIndex = 6;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy6; //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy6;
}
public void Trophy77()
{
 CavatarIndex = 7;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy7; //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy7;
}
public void Trophy88()
{
 CavatarIndex = 8;
 PlayerPrefs.SetInt("CurrentAvatar", CavatarIndex);
 CurrentAvatar.sprite = Trophy8; //change the source image of the image "CurrentAvatar" to the sprite "Trophy1" 
 CAM.drawMode = SpriteDrawMode.Sliced;
 CAM.size = new Vector2(3,3);
 CAM.sprite= Trophy8;
}
    // Start is called before the first frame update
   void Update()
   {    
     switch (PlayerPrefs.GetInt("CurrentAvatar"))
      {
              case 0:
              CurrentAvatar.sprite = Trophy;
              CAM.drawMode = SpriteDrawMode.Sliced;
              CAM.size = new Vector2(3,3);
              CAM.sprite= Trophy;
             
              break;
              
              case 1:
              CurrentAvatar.sprite = Trophy1;
              CAM.drawMode = SpriteDrawMode.Sliced;
              CAM.size = new Vector2(3,3);
              CAM.sprite= Trophy1;
              break;

              case 2:
              CurrentAvatar.sprite = Trophy2;
              CAM.drawMode = SpriteDrawMode.Sliced;
              CAM.size = new Vector2(3,3);
               CAM.sprite= Trophy2;
              break;

              case 3:
              CurrentAvatar.sprite = Trophy3;
              CAM.drawMode = SpriteDrawMode.Sliced;
              CAM.size = new Vector2(3,3);
              CAM.sprite= Trophy3;
              break;

              case 4:
             CurrentAvatar.sprite = Trophy4;
             CAM.drawMode = SpriteDrawMode.Sliced;
             CAM.size = new Vector2(3,3);
             CAM.sprite= Trophy4;
              break;

              case 5:
             CurrentAvatar.sprite = Trophy5;
             CAM.drawMode = SpriteDrawMode.Sliced;
             CAM.size = new Vector2(3,3);
             CAM.sprite= Trophy5;
              break;

              case 6:
             CurrentAvatar.sprite = Trophy6;
             CAM.drawMode = SpriteDrawMode.Sliced;
             CAM.size = new Vector2(3,3);
             CAM.sprite= Trophy6;
              break;

              case 7:
             CurrentAvatar.sprite = Trophy7;
             CAM.drawMode = SpriteDrawMode.Sliced;
             CAM.size = new Vector2(3,3);
             CAM.sprite= Trophy7;
              break;

              case 8:
             CurrentAvatar.sprite = Trophy8;
             CAM.drawMode = SpriteDrawMode.Sliced;
             CAM.size = new Vector2(3,3);
             CAM.sprite= Trophy8;
              break;

              default:
              CurrentAvatar.sprite = null;
              CAM.sprite= null;
              break;
      }

   }
}
