using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public Granat granatprefab;
    public Rigidbody2D rb;
    float timerr;
    // Update is called once per frame    ian
    void Update()   //om man trycker skjut knappen så aktiveras Shoot   Ian
    {
        if (Input.GetButtonDown("Fire1")&& rb.velocity == Vector2.zero) // trycker man ner fire1 så sjuter man    Ian/ och enbart om man står still/Timothy
        {
            Shoot();
        }
        timerr += Time.deltaTime; // detta gör så att när ma  skjutit sin granat så startar en timer för när den sprängs
            if (Input.GetButtonDown("Fire2")&& timerr > 10) // trycker man ner fire2 så sjuter man sin granat    Ian
        {
            granat();
            timerr = 0;
        }
    }
    

    void Shoot()
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation); // aktiverar bulletprefaben   Ian
    }

    void granat()
    {
      Granat nygranat = Instantiate(granatprefab, FirePoint.position, FirePoint.rotation);
    }

}
