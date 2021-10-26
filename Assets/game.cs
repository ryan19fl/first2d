using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    private void Start()
    {
        healthsys healthsys = new healthsys(100);
        Debug.Log("health" + healthsys.Gethealth());
        healthsys.damage(10);
        Debug.Log("health" + healthsys.Gethealth());
        healthsys.heal(10);
        Debug.Log("health" + healthsys.Gethealth());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
