using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class personaje : MonoBehaviour
{
    public float speed=4.0f;
    public Rigidbody2D rb;
    Vector2 move;
    Vector2 mousePos;
    public Camera cam;
    public Animator anim;
    public Transform mira;
    public int life=3;
    int mlife;
    bool damaged=false;
    

    public int numbofhearts;
    public Image[] hearts;
    public Sprite fullhearts;

    public bool key1=false;
    public bool key2 = false;
    public GameObject door1;
    public GameObject door2;
    public popup advise;
    public bool allkeys=false;

    public int numbofkeys;
    public Image[] keys;
    public Sprite fullkey;
    public int keysnumber=0;
    void awake()
    {
        advise=GetComponent<popup>();
        rb = GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
    }
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        move.x= Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        mousePos=cam.ScreenToWorldPoint(Input.mousePosition);

        //mira del mouse
        mira.position=Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));

       //vida
       for(int i=0;i < hearts.Length; i++)
        {

            if(i < numbofhearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        numbofhearts = life;
        //llaves
        for(int j=0;j < keys.Length; j++)
        {
            if (j < numbofkeys)
            {
                keys[j].enabled = true;
            }
            else
            {
                keys[j].enabled = false;
            }
        }
        numbofkeys = keysnumber;
        if (key1 == true && key2 == true)
        {
            allkeys = true;
        }
        
    }
    public void morekey()
    {
        keysnumber++;
    }
    public void lesskey()
    {
        keysnumber--;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move*speed*Time.fixedDeltaTime);
        
    }

   public void morelife()
   {
        mlife = Random.Range(1,4);
        print("recuperaste " + mlife + " de vida");
        life = life + mlife;
        print("vida total "+life);
        if (life >3)
        {
            life = 3;
        }
   }

    public void lesslife(int lelife)
    {              
        life = life - lelife;
        print("tenes vida" + life);
        StartCoroutine(ExampleCoroutine());


        //if (life <= 0)
        //{
        //    SceneManager.LoadScene(4);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 12 || collision.gameObject.layer == 20)
        {
            print("tenes vida" + life);
            if (damaged == false)
            {
                damaged = true;
                lesslife(1);
            }
            
        }
        if (collision.gameObject.layer == 23)
        {
            key1 = true;
            morekey();
        }
        if (collision.gameObject.layer == 25)
        {
            key2 = true;
            morekey();
        }
        
        
       
        if (collision.gameObject.layer == 26 && key1 == true && key2==true)
        {
            Destroy(door2);
            key1 = false;
            key2 = false;
        }
        
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        damaged = false;
    }

    public void up()
    {
        anim.SetBool("adelante", true);
        anim.SetBool("atras", false);
        anim.SetBool("izquierda", false);
        anim.SetBool("derecha", false);
    }
    public void Down()
    {
        anim.SetBool("atras", true);
        anim.SetBool("izquierda", false);
        anim.SetBool("derecha", false);
        anim.SetBool("adelante", false);
    }

    public void left()
    {
        anim.SetBool("izquierda", true);
        anim.SetBool("derecha", false);
        anim.SetBool("adelante", false);
        anim.SetBool("atras", false);
    }
    public void right()
    {
        anim.SetBool("derecha", true);
        anim.SetBool("atras", false);
        anim.SetBool("izquierda", false);
        anim.SetBool("adelante", false);
    }

}
