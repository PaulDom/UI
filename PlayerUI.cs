using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    // Скрипт игрока
    public Player playerScript;
    public Slider healthSlider;

    private void Update()
    {
        healthSlider.maxValue = playerScript.maxHealth;
        healthSlider.value = playerScript.health;
    }
}
