using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup2 : MonoBehaviour
{
    public Transform popupspawn;
    public GameObject popupbox;
    destruir destroy;
    personaje player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<personaje>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && player.allkeys == false)
        {
            GameObject pop = Instantiate(popupbox, popupspawn.position, popupspawn.rotation);
        }
        else if (collision.gameObject.layer == 8 && player.allkeys==true)
        {
            Destroy(gameObject);
            player.key1 = false;
            player.key2 = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && player.allkeys == false)
        {
            destroy = GameObject.FindGameObjectWithTag("popup").GetComponent<destruir>();
            destroy.destroypop();
        }
        
    }

}
