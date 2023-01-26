using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject AmmoInstiate;
    public Transform spawnPoint;

    public void Start()
    {
        Shoot();

    }
    public void Update()
    {
        
        
    }

    private void Shoot()
    {
        Instantiate(AmmoInstiate, spawnPoint.position, transform.rotation);
        Debug.Log("Disparo realizado");
    }
}
