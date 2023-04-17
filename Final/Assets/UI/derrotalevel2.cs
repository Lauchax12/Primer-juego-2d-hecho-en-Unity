using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class derrotalevel2 : MonoBehaviour
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
}
