using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertallave : MonoBehaviour
{
    public personaje player;

    void awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<personaje>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && player.key1 == true)
        {
            player.key1 = false;
            Destroy(gameObject);
        }
    }
}
