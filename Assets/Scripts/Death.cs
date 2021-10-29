using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "acid")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
