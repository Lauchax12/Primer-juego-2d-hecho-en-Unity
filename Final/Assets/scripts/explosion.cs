using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject explotion;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.instance.Play("bala chocando");
        GameObject effect = Instantiate(explotion, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }
}
