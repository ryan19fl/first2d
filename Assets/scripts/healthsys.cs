using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthsys : MonoBehaviour
{
    public int healthMax=100;
    public int health=100;
    public int amount = 10;
    public int healamount =20;
    public Animator anim;

    public healthsys(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }

    public float GetHealthPercent()
    {
        return (float)health / healthMax;
    }

    public void Damage()
    {
        health -= amount;
        if (health < 0)
        {
           
            health = 0;
        }
      
        if (health <= 0)
        {
           Destroy(gameObject);
        }
        anim.SetTrigger("hurt");
        

    }

    

    public void Heal()
    {
        health += amount;
        if (health > healthMax)
        {
            health = healthMax;
        }
    }
    private void Update()
    {
       // Damage();
    }
}



