using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granat : MonoBehaviour

{
    float timerr;
    Rigidbody2D body;
    CircleCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<CircleCollider2D>();
        body = GetComponent<Rigidbody2D>();
        body.AddForce(Vector2.up * 300);
    }

    // Update is called once per frame
    void Update()
    {
        timerr += Time.deltaTime; // detta gör så att när ma  skjutit sin granat så startar en timer för när den sprängs
        if (timerr > 5)
        {
            print("boom");
            collider.radius = 10;
            Destroy(gameObject); // förstör granat onjektet när timer nått sitt slut
        }
    }
}
