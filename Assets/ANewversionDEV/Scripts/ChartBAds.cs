using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
//using ChartboostSDK;
//using TappxSDK;

public class ChartBAds : MonoBehaviour
{
  public GameObject Resumer;
   AdColony.AdColonyAdView adView;
    public string[] zoneIds = new string[] { "vz92e0e981cd9242f9a8" };
    public string[] zoneIds2 = new string[] { "vzc9149621c2014b868c" };
    public string APP_ID = "appdc686f4772ed4d6bbc";



    public string[] zoneIdsIOS = new string[] { "vzddc535a453b64bb494" };
    public string[] zoneIds2IOS = new string[] { "vz3b57e65812d040ae84" };
    public string APP_IDIOS = "app0185cdfd437c4d14ac";
 // bool autoShow = false;
    // Start is called before the first frame update
    void Start()
    {
      AdColony.AppOptions appOptions = new AdColony.AppOptions();
      appOptions.AdOrientation = AdColony.AdOrientationType.AdColonyOrientationLandscape;
      AdColony.Ads.Configure("appdc686f4772ed4d6bbc", appOptions, zoneIds);
      AdColony.Ads.Configure("app0185cdfd437c4d14ac", appOptions, zoneIds);
      //Chartboost.cacheInterstitial(CBLocation.Default);
      //Chartboost.cacheRewardedVideo(CBLocation.Default);

       
AdColony.Ads.OnAdViewLoaded += (AdColony.AdColonyAdView ad) => {
    adView = ad;
};

AdColony.Ads.OnAdViewFailedToLoad += (AdColony.AdColonyAdView ad) => {
    Debug.Log("Banner ad failed to load");
};

       if(Resumer.activeSelf == true)
        {
          ShowBanner();
        }
     //TappxManagerUnity.instance.loadInterstitial(autoShow);

    }

    // Update is called once per frame
    public void ShowInterstitial()
    {
      AdColony.InterstitialAd _ad = null;
      AdColony.Ads.OnRequestInterstitial += (AdColony.InterstitialAd ad) => {
    _ad = ad;
};

       AdColony.Ads.RequestInterstitialAd(zoneIds2[0], null);
       AdColony.Ads.RequestInterstitialAd(zoneIdsIOS[0], null);
       
        if (_ad != null) {
    AdColony.Ads.ShowAd(_ad);
}
    }
    public void ShowBanner()
    { 
       AdColony.AdOptions adOptions = new AdColony.AdOptions();
       AdColony.Ads.RequestAdView(zoneIds[0], AdColony.AdSize.Banner, AdColony.AdPosition.Bottom, adOptions);
       AdColony.Ads.RequestAdView(zoneIds2IOS[0], AdColony.AdSize.Banner, AdColony.AdPosition.Bottom, adOptions);

   
    adView.ShowAdView();

  
     // bool mrec = false;
      
      //Chartboost.showInterstitial (CBLocation.Default);

    }
    public void HideBanner()
    {
      adView.HideAdView();
     // TappxManagerUnity.instance.hide();
    }
}
