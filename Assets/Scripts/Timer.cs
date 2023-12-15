using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public int seconds;
    public int s = 100;

    // Update is called once per frame
    void Update()
    {   
        s -= 1;

        if (s == 0)
        {
            seconds -= 1;
            s = 100;
            print("s = " + seconds);
            print("m = " + minutes);
        }
        if (minutes <= 0 && seconds <= 0)
        {
            print("TTP");
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }

        if (seconds == 0)
        {
            minutes -= 1;
            seconds = 60;
        }
       
    }
}
