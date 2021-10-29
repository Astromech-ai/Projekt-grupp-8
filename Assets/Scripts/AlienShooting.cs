using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AlienShooting : MonoBehaviour
{

    public Transform FirePoint;
    public GameObject BulletPrefab;
    public Rigidbody2D rb;

    void Start()
    {
        StartCoroutine(waiting());
    }

    IEnumerator waiting()
    {
        int wait_time = Random.Range(1, 3);
        yield return new WaitForSeconds(wait_time);

        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation); // aktiverar bulletprefaben   Ian
        StartCoroutine(waiting());
    }

}
