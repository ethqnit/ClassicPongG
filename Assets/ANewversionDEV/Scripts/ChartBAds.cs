using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
 using StartApp;

public class ChartBAds : MonoBehaviour
{
  public GameObject Resumer;
  
 // bool autoShow = false;
    // Start is called before the first frame update
    void Start()
    {
       
       if(Resumer.activeSelf == true)
        {
          ShowBanner();
        }
    }

    // Update is called once per frame
    public void ShowInterstitial()
    {
     AdSdk.Instance.ShowDefaultAd();
    }
    public void ShowBanner()
    { 
   
   var banner = AdSdk.Instance.CreateBanner();    
   banner.ShowInPosition(BannerAd.BannerPosition.Bottom);
   

    }
    public void HideBanner()
    {
      var banner = AdSdk.Instance.CreateBanner();
      if( banner.IsShownInPosition(BannerAd.BannerPosition.Bottom))
      {
         banner.Hide();
      }
     
      
     
     {

     }
    }
}
