using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Achivements : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI disText;
    
    // Start is called before the first frame update
    void Start()
    {
        LoadCoinCount();
        LoadDisCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadCoinCount()
    {
        int coinCount = PlayerPrefs.GetInt("CoinCount");
        coinText.text = coinCount.ToString();
        
        // if (coinText != null)
        // {
        //     coinText.text = coinCount.ToString();
        // }
        // else
        // {
        //     Debug.LogWarning("coinText is not assigned!");
        // }
    }

     void LoadDisCount()
    {
        int disCount = PlayerPrefs.GetInt("DisCount");
        disText.text = disCount.ToString();
    }
}
