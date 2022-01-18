using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    public Rigidbody2D ri2;
    public float Ej_scale;
    public Animator anim;
    public healthsys hs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(ri2.velocity.y) <= 0)
        {
            ri2.AddForce(Vector2.up * Ej_scale, ForceMode2D.Impulse);
            
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            // Destroy(collision.gameObject);

            //collision.gameObject.GetComponent<player>().Updateplayerhealth(-10);
            StartCoroutine(wait());

        }

    }
    IEnumerator wait()
    {

        hs.Damage();
        yield return new WaitForSeconds(5);
    }
}
