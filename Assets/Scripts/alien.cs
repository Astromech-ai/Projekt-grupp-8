using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien : MonoBehaviour
{

    public Transform[] position;
    public Transform location;
    




    private void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "bullet")
        {
           AlienSpawner.alienCount -=1;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
