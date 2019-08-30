using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barreira : MonoBehaviour
{
 
    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 4;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position =
            new Vector3(transform.position.x,
            transform.position.y - range * Random.value,
            transform.position.z);
 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
