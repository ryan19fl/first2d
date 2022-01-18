using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectingPoints : MonoBehaviour
{
    private float points=0;

    private void OnTriggerEnter2D(Collider2D ppp)
    {
        if(ppp.transform.tag=="points")
        {
            Destroy(ppp.gameObject);
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
