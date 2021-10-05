using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D ri;
    public float jumpscale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x, 0) * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))//&&Mathf.Abs(ri.velocity.y)<=0)
        {
            ri.AddForce(new Vector2(0, jumpscale), ForceMode2D.Impulse);
        }
        //if(ri.velocity.magnitude<speed)

    }
}
