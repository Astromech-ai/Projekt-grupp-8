using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien : MonoBehaviour
{

 



    private void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "bullet")
        {
            AlienSpawn.alienCount -=1;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
