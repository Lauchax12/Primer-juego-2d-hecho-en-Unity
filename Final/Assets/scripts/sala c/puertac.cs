﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertac : MonoBehaviour
{
    public int enemys = 4;
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
