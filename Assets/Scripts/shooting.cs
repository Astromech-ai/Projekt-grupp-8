using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public Granat granatprefab;
    float timerr;
    // Update is called once per frame    ian
    void Update()   //om man trycker skjut knappen så aktiveras Shoot   Ian
    {
        if (Input.GetButtonDown("Fire1")) // trycker man ner fire1 så sjuter man    Ian
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
