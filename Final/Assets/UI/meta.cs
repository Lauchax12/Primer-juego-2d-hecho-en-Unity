using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meta : MonoBehaviour
{
    public personaje player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<personaje>();
    }
    private void Update()
    {
        if (player.life <= 0)
        {
            print("funcione");
            SceneManager.LoadScene(7);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            SceneManager.LoadScene(5);
        }

    }
}
