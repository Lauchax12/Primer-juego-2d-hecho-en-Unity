using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo2 : MonoBehaviour
{
    public Transform fire2;

    public GameObject bullet;
    public float force = 20f;

    
    
    bool triple = true;

    
    public void tripleshoot()
    {
        
        GameObject shoot = Instantiate(bullet, fire2.position, fire2.rotation);       
        Rigidbody2D rb = shoot.GetComponent<Rigidbody2D>();
        rb.AddForce(fire2.up * force, ForceMode2D.Impulse);
    }
    
}
