using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealthbar : MonoBehaviour
{
    private Transform bar;
  
    // Start is called before the first frame update
   private void Start()
    {
        bar = transform.Find("bar");
       
    }
    public void setsize(float sizenormalized)
    {
        bar.localScale = new Vector3(sizenormalized, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
