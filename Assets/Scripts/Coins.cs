using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    int coins = 0;

    private void OnTriggerEnter(Collider other)
    {
        coins = other.GetComponent<Coins>().coins += 1;
        print("You picked a coin");
        print("Now coins: " + coins);
    }
}
