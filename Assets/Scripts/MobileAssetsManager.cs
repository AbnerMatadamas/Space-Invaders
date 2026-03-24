using UnityEngine;

public class MobileAssetsManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] mobileAssets;
    [SerializeField]
    private GameObject[] desktopAssets;
    private void Awake()
    {
        #if UNITY_EDITOR || UNITY_STANDALONE
            foreach(GameObject asset in desktopAssets)
            {
                asset.SetActive(true);
            }
        #else
            foreach(GameObject assets in mobileAssets)
            {
            asset.SetActive(true);
            }
        #endif        
    }
}
