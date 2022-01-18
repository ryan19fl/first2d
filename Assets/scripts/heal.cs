using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    private float cherry = 0;
    public healthsys hs;
    private void OnTriggerEnter2D(Collider2D hhh)
    {
        if (hhh.transform.tag == "cheries")
        {
           
            Destroy(hhh.gameObject);
            hs.Heal();
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
