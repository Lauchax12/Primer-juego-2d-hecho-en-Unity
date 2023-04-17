using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigof : MonoBehaviour
{
    int life = 3;
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movement;
    public float speed = 3.0f;
    public GameObject death;
    puertaf pb;
    public GameObject puerta;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;

        //para que rote
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
        
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            life = life - 1;
            print(life);
            if (life <= 0)
            {

                pb = GameObject.FindGameObjectWithTag("TagF").GetComponent<puertaf>();
                pb.enemydeath(gameObject);
                deathanim();
            }

        }
    }

    void deathanim()
    {
        GameObject effect = Instantiate(death, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }
}
