using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
// Start is called before the first frame update
{

    private void OnCollisionStay2D(Collision2D player)
    {
        if(player.gameObject.tag=="player")
        {
            Destroy(player.gameObject);
        }
            
    }


}
