using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public charactorcontroler controller;
    public float runspeed=40f;
    float horizontalmove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal")*runspeed;

    }
    private void FixedUpdate()
    {
        controller.move(horizontalmove * Time.fixedDeltaTime, false, false);
    }
}
