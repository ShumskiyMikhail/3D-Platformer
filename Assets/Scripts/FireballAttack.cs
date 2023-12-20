using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    public GameObject fierballPrefab;
    public Transform attacPoint;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fierballPrefab, attacPoint.position, attacPoint.rotation);
        }
    }
}
