using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adManager : MonoBehaviour , IUnityAdsListener
{
    string GooglePlay_id = "3939441";
    bool GameMode = true;
    string myplacementID = "rewardedVideo";
    
    


  
    private void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(GooglePlay_id, GameMode);
        
       
    }
   
    
    public void displayAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show(myplacementID);
        }
       
    }

    public void OnUnityAdsReady(string placementId)
    {
    
    }

    public void OnUnityAdsDidError(string message)
    {
    
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        
        if (showResult == ShowResult.Finished)
        {
            
            Time.timeScale = 1f;
            FindObjectOfType<GameManager>().RHBU();
            
            FindObjectOfType<movement>().revived();
           
        }

    }

}
