using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {     
        if (collision.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }
}
