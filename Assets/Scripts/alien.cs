using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien : MonoBehaviour
{

    public Transform[] position;
    public Transform location;
    public GameObject Alien;
    public int level = 0;
    public int alienCount = 1;





    private void Update()
    {
       if(alienCount == 0)
        {
            print("test");
            level += 1;
        }
       if(level == 1)
        {

        }
    }




    private void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "bullet")
        {
            level -=1;
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
