using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public AudioSource coinSound;

    void OnTriggerEnter(Collider other)
    {
        coinSound.Play();
        CollectableControler.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
