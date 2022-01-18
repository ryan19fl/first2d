using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealthbar : MonoBehaviour
{
    public Transform bar;
   // public SpriteRenderer sr;

    public healthsys healthSystem;
    private void Update()
    {
        UpdateHealthBar();
    }
    private void UpdateHealthBar()
    {
        Debug.Log(healthSystem.GetHealthPercent());
        bar.localScale = new Vector3(healthSystem.GetHealthPercent(), 1);
    }
}
