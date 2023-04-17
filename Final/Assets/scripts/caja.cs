using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour
{
    public Rigidbody2D rb;
    disparo shoot;


    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
        shoot = GameObject.FindGameObjectWithTag("Player").GetComponent<disparo>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (shoot.ammo <12)
            {
                AudioManager.instance.Play("recarga");
                
                shoot.fullammo();
                Destroy(gameObject);
            }
           
        }
    }

    
}
