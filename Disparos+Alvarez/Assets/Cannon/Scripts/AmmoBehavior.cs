using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehavior : MonoBehaviour
{
    public float speed;
    public float direction;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El disparo hará " + damage + " de daño");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
        
    }
}
