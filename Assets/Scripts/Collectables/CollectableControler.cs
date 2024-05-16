using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControler : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;
    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
        coinEndDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
        OnGameQuit();
    }

    void OnGameQuit()
    {
        PlayerPrefs.SetInt("CoinCount", coinCount);
        PlayerPrefs.Save();
    }
}
