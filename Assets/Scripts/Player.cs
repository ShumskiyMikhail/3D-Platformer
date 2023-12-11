using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрка: " + health);
        if (health == 0)
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }
    }
}
