using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;

    // Update is called once per frame
    public void Update()
    {   
        seconds -= Time.deltaTime;

        if (minutes <= 0 && seconds <= 0)
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }

        if (seconds <= 0)
        {
            minutes -= 1;
            seconds = 60;
        }
    }
}
