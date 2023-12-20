using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public Object thisCoin;
    public void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.CollectCoins();
        Destroy(thisCoin);
    }
}
