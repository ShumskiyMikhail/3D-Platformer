using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public Object thisCoin;
    public void OnTriggerEnter(Collider other)
    {
        CoinsCounter player = other.GetComponent<CoinsCounter>();
        player.CollectCoins();
        Destroy(thisCoin);
    }
}
