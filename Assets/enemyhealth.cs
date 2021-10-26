using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyhealth : MonoBehaviour
{
    public enemy enemyHealth;
    public Slider Slider;
    public Color Low;
    public Color High;
    //public Vector3 Offset;
    public Image fillImage;

    public void SetHealth()
    {
       // Slider.gameObject.SetActive(enemyHealth.enemyhealth < enemyHealth.enemyMaxhealth);
        Slider.value = enemyHealth.enemyhealth;
        Slider.maxValue = enemyHealth.enemyMaxhealth;

       // Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    }

    void Update()
    {
        SetHealth();    
       // Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
    }
}
