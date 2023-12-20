using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public AudioSource audioSource;
    public AudioClip audioClip;
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
}
