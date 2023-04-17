using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo3 : MonoBehaviour
{
    public Transform fire3;

    public GameObject bullet;
    public float force = 20f;



    bool triple = true;

    
    public void tripleshoot()
    {
        
        GameObject shoot = Instantiate(bullet, fire3.position, fire3.rotation);
        Rigidbody2D rb = shoot.GetComponent<Rigidbody2D>();
        rb.AddForce(fire3.up * force, ForceMode2D.Impulse);
    }

}
