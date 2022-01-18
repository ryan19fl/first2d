using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{ 
    public float speed;
    public Rigidbody2D ri;
    public float jumpscale;
    private SpriteRenderer sr;
    public Animator anim;
    //public int health;
    //private healthsys healthsys;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
    }

    //Update is called once per frame
    //public void Updateplayerhealth(int damage)
    //{
    //      health+= damage;
    //    if (health <= 0f)
    //    {
    //       // Destroy(gameObject);
    //    }
    //}
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x, 0) * speed * Time.deltaTime;
        if (x > 0)
        {
            x += speed * Time.deltaTime;
            sr.flipX = false;
            anim.SetBool("run", true);
        }
        else if (x < 0)
        {
            x -= speed * Time.deltaTime;
            sr.flipX = true;
            anim.SetBool("run", true);
        }
        else if (x == 0)
        {
            anim.SetBool("run", false);
        }
        if (Input.GetKeyDown(KeyCode.Space)&&Mathf.Abs(ri.velocity.y)<=0)
        {
            ri.AddForce(Vector2.up* jumpscale,ForceMode2D.Impulse);
          
        }

        if (ri.velocity.y > 0)
        {

            anim.SetBool("jump", true);
        }
        else if (ri.velocity.y <= 0)
        {

            anim.SetBool("jump", false);

        }

        //if(ri.velocity.magnitude<speed)

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
           // Destroy(collision.gameObject);
            collision.gameObject.GetComponent<enemy>().UpdateEnemyhealth(-10f);
        }
    }

}
