using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    public int enemys=2;
    bool opensesame = false;
    
    
    private void Update()
    {
        if(opensesame == true)
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
            print("ta está");
           
        }
        else
        {
            enemys = enemys - 1;
            if(enemys <= 0)
            {
                enemys = 0;
            }
            print("hay " + enemys + " enemigos");
        }
        
    }
}
