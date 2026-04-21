using UnityEngine;

public class PlatformDetection : MonoBehaviour
{
    void Start()
{
    // Runtime platform kontrolü (Editor'de test için)
    bool isMobilePlatform = Application.platform == RuntimePlatform.Android || 
                           Application.platform == RuntimePlatform.IPhonePlayer;
    
    gameObject.SetActive(isMobilePlatform);
    
    Debug.Log("Platform: " + Application.platform + " | Mobile Controls: " + isMobilePlatform);
}
}