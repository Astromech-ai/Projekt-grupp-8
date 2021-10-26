using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public GameObject Alien;
    public int level = 1;
    public static int alienCount = 1;





    private void Update()
    {
        if (alienCount == 0)
        {
           
            level += 1;
            for (int i = 0; i < level; i++)
            {
                if (alienCount < level)
                {
                    Instantiate(Alien, new Vector3(Random.Range(-5, 5), 4, 0), Alien.transform.rotation);
                    alienCount++;
                }

            }
        }

    }
}
