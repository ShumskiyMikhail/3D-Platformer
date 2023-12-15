using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;
    public GameObject fierballPrefab;
    public Transform attacPoint;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public int coins = 0;

    public void CollectCoins()
    {
        coins += 1;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        
        print("Здоровье игрка: " + health);
        if (health == 0)
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }
        else
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fierballPrefab, attacPoint.position, attacPoint.rotation);
        }
    }
}
