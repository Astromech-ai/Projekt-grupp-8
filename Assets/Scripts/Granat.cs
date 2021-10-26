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
        timerr += Time.deltaTime; // detta g�r s� att n�r ma  skjutit sin granat s� startar en timer f�r n�r den spr�ngs
        if (timerr > 5)
        {
            print("boom");
            collider.radius = 10;
            Destroy(gameObject); // f�rst�r granat onjektet n�r timer n�tt sitt slut
        }
    }
}
