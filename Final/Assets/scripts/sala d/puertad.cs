using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertad : MonoBehaviour
{
    public int enemys = 2;
    bool opensesame = false;


    private void Update()
    {
        if (opensesame == true)
        {
            Destroy(gameObject);
        }

        if (enemys <= 0)
        {
            opensesame = true;
        }

    }
    public void enemydeath(GameObject g)
    {
        if (enemys <= 0)
        {
            opensesame = true;

        }
        else
        {
            enemys = enemys - 1;
            print("hay " + enemys + " enemigos");
        }

    }
}
