using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour
{
    public Rigidbody2D rb;
    public personaje Player;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<personaje>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 )
        {
            if (Player.life < 3)
            {
                Player.morelife();
                Destroy(gameObject);
            }
            
        }
    }
}
