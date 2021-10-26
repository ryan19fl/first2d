using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public Rigidbody2D ri2;
    public float Ejscale;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(ri2.velocity.y) <= 0)
        {
            ri2.AddForce(Vector2.up * Ejscale, ForceMode2D.Impulse);
            
        }
        if (ri2.velocity.y > 0)
        {

            anim.SetBool("jump", true);
        }
        else if (ri2.velocity.y <= 0)
        {

            anim.SetBool("jump", false);

        }
    }
}
