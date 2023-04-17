using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    personaje Player;
    public Rigidbody2D rb;

    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<personaje>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("arriba"))
        {
            Player.up();
        }
        if (other.gameObject.CompareTag("abajo"))
        {       
            Player.Down();
        }
        if (other.gameObject.CompareTag("der"))
        {
            
            Player.right();
        }
        if (other.gameObject.CompareTag("izq"))
        {
            
            Player.left();
        }
    }
}
