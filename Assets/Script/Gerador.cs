using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{
    public GameObject zezinho;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createobstacle", 1f, 1.5f);
        
    }

    // Update is called once per frame
    void createobstacle()
    {
        Instantiate(zezinho);
    }
}
