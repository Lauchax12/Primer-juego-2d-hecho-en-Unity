using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disparo : MonoBehaviour
{
    public Transform fire;
    
    public GameObject bullet;
    public float force=20f;
    public int ammo=6;
    public Text ammodisplay;
    bool triple = true;
    disparo2 shoot2;
    disparo3 shoot3;

    // Update is called once per frame
    void Update()
    {
        if(ammo >= 3)
        {
            triple = true;
        }
        else
        {
            triple = false;
        }

        ammodisplay.text = ammo.ToString();
        if (Input.GetMouseButtonDown(1)&&triple==true)
        {
            tripleshoot();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (ammo <=0)
            {
                print("no ammo");
            }
            else
            {
               
                shooting();
            }
            
        }
    }
   

    void shooting()
    {
        AudioManager.instance.Play("laser");
        ammo = ammo - 1;
        GameObject shoot=Instantiate(bullet, fire.position, fire.rotation);
        Rigidbody2D rb=shoot.GetComponent<Rigidbody2D>();
        rb.AddForce(fire.up * force, ForceMode2D.Impulse);
    }



    void tripleshoot()
    {     
        AudioManager.instance.Play("laser");
        GameObject shoot = Instantiate(bullet, fire.position, fire.rotation);
        ammo = ammo -3;
        shoot2 = GameObject.FindGameObjectWithTag("Player").GetComponent<disparo2>();
        shoot2.tripleshoot();
        shoot3 = GameObject.FindGameObjectWithTag("Player").GetComponent<disparo3>();
        shoot3.tripleshoot();
        Rigidbody2D rb = shoot.GetComponent<Rigidbody2D>();
        rb.AddForce(fire.up* force, ForceMode2D.Impulse);
        

    }
    public void fullammo()
    {
        int more = Random.Range(3, 7);
        ammo = ammo + more;
        if(ammo >= 12)
        {
            ammo = 12;
        }
    }
}
