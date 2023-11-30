using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : Singleton<PlayerUI>
{
    [SerializeField] Slider healthbar;
    [SerializeField] TextMeshProUGUI healthTextObject;
    [SerializeField] string healthText;

    public void UpdateHealthbar(int currentHealth, int maxHealth)
    {
        healthbar.value = (float)currentHealth / (float)maxHealth;

        if (currentHealth >= 0) healthTextObject.text = healthText + (int)currentHealth + "/" + maxHealth;
        else healthTextObject.text = healthText + "0/" + maxHealth;
    }
}
