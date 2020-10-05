using GameJolt.API;
using GameJolt.UI;
using UnityEngine;
using UnityEngine.UI;

public class SignedIinName : MonoBehaviour
{
    public Text name;
    // Start is called before the first frame update
    void Start()
    {
         if(GameJoltAPI.Instance.HasUser) 
			{
				GameJoltUI.Instance.QueueNotification(
				name.text = GameJoltAPI.Instance.CurrentUser.Name);
         }   
    }

    // Update is called once per frame
    public void Pressed()
    {
       if(GameJoltAPI.Instance.HasUser) 
			{
				
				name.text = GameJoltAPI.Instance.CurrentUser.Name;
            }   
    }
}
