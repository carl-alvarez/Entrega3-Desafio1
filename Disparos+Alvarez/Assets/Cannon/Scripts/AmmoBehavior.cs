using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehavior : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El disparo hará " + damage + " de daño");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        
    }
}
