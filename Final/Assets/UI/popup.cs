using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class popup : MonoBehaviour
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
        if (collision.gameObject.layer == 8 && player.key1==false)
        {
            GameObject pop = Instantiate(popupbox, popupspawn.position, popupspawn.rotation);
        }else if (collision.gameObject.layer == 8 && player.key1 ==true)
        {
            Destroy(gameObject);
            player.key1 = false;
            player.lesskey();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && player.key1 == false)
        {
            destroy = GameObject.FindGameObjectWithTag("popup").GetComponent<destruir>();
            destroy.destroypop();
        }
    }

}
