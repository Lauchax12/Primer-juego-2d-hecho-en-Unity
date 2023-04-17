using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torreta : MonoBehaviour
{
    
    public float range;
    public Transform player;
    bool detected = false;
    Vector2 direction;
    public GameObject gun;
    public GameObject bullet;
    public float firerate;
    float timing = 0;
    public Transform shootpoint;
    public float force;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = player.position;
        direction = targetPos - (Vector2)transform.position;
        RaycastHit2D rayinfo = Physics2D.Raycast(transform.position, direction, range);

        if (rayinfo)
        {
            if (rayinfo.collider.gameObject.tag == "Player")
            {
                if (detected == false)
                {
                    detected = true;
                }
            }
            else
            {
                if (detected == true)
                {
                    detected = false;
                }
            }

        }
        if (detected)
        {
            gun.transform.up = direction;
            if(Time.time > timing)
            {
                timing = Time.time + 1 / firerate;
                shoot();
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        //visualizar el area del raycast
        Gizmos.DrawWireSphere(transform.position, range);
    }

    void shoot()
    {
       GameObject bulletins= Instantiate(bullet,shootpoint.position,Quaternion.identity);
        bulletins.GetComponent<Rigidbody2D>().AddForce(direction * force);
    }
    
    
    
}
