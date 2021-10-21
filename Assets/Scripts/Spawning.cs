using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Aliens;
    public float spawnTime = 5f;
    
    void Start()
    {
        InvokeRepeating("AlienSpawn", spawnTime, spawnTime);
    }

    
 
    void AlienSpawn()
    {

        var newpAlienSpawn = (GameObject)Instantiate(Aliens, SpawnPoint.transform.position, transform.rotation);
    }
}
