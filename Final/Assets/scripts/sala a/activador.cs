using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activador : MonoBehaviour
{
    public Rigidbody2D rb;
    

    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }
    

}
