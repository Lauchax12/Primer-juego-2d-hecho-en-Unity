using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torretahitbox : MonoBehaviour
{
    int life = 6;
    public GameObject torreta;
    public GameObject key;
    public Transform droppoint;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            life = life - 1;
            print(life);
            if (life <= 0)
            {
                GameObject keyinput = Instantiate(key, droppoint.position, droppoint.rotation);
                Destroy(torreta);
                Destroy(gameObject);
            }
        }
    }
}
