using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Health player1;
    public CoinsCounter player2;
    public Timer player3;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    public TextMeshProUGUI timer;

    private void Update()
    {
        healthSlider.maxValue = player1.maxHealth;
        healthSlider.value = player1.health;
        coinsCounterText.text  = player2.coins.ToString();
        timer.text = player3.seconds.ToString();
    }
}
