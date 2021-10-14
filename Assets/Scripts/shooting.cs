using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    // Update is called once per frame
    void Update()   //om man trycker skjut knappen så aktiveras Shoot
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    

    void Shoot()
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
    }
}
