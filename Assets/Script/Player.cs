using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 JumpForce = new Vector2(0, 300);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Jump através do teclado
        if (Input.GetKeyUp("space"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(JumpForce);
        }
        //Morrer quando sair da tela
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)

        {
            Die();

        }
    }
          
        void Die()
        {
            Application.LoadLevel(Application.loadedLevel);

        }
        
    
}


