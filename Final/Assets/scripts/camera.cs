using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    
    int a=0;
    int b=0;
    int c = 0;
    int d = 0;
    int e = 0;
    int f = 0;
    
    public Transform ha;
    public Transform hb;
    public Transform hc;
    public Transform hd;
    public Transform he;
    public Transform hf;

    public Transform Maincamera;

    private void Start()
    {
        a = 1;
    }
    private void FixedUpdate()
    {
        if (a==1)
        {
            Vector3 nuevapos = Vector3.Lerp(transform.position, ha.position, 5f * Time.deltaTime);
            nuevapos.z = -10;
            Maincamera.transform.position = nuevapos;
        }
        if (b == 1)
        {
            Vector3 nuevapos = Vector3.Lerp(transform.position, hb.position, 5f * Time.deltaTime);
            nuevapos.z = -10;
            Maincamera.transform.position = nuevapos;
        }
        if (c == 1)
        {
            Vector3 nuevapos = Vector3.Lerp(transform.position, hc.position, 5f * Time.deltaTime);
            nuevapos.z = -10;
            Maincamera.transform.position = nuevapos;
        }
        if (d == 1)
        {
            Vector3 nuevapos = Vector3.Lerp(transform.position, hd.position, 5f * Time.deltaTime);
            nuevapos.z = -10;
            Maincamera.transform.position = nuevapos;
        }
        if (e == 1)
        {
            Vector3 nuevapos = Vector3.Lerp(transform.position, he.position, 5f * Time.deltaTime);
            nuevapos.z = -10;
            Maincamera.transform.position = nuevapos;
        }
        if (f == 1)
        {
            Vector3 nuevapos = Vector3.Lerp(transform.position, hf.position, 5f * Time.deltaTime);
            nuevapos.z = -10;
            Maincamera.transform.position = nuevapos;
        }
    }

    public void roomA()
    {
        a = 1;
        b = 0;
        c = 0;
        d = 0;
        e = 0;
        f = 0;
    }

    public void roomB()
    {
        a = 0;
        b = 1;
        c = 0;
        d = 0;
        e = 0;
        f = 0;
    }
    public void roomC()
    {
        a = 0;
        b = 0;
        c = 1;
        d = 0;
        e = 0;
        f = 0;
    }
    public void roomD()
    {
        a = 0;
        b = 0;
        c = 0;
        d = 1;
        e = 0;
        f = 0;
    }
    public void roomE()
    {
        a = 0;
        b = 0;
        c = 0;
        d = 0;
        e = 1;
        f = 0;
    }
    public void roomF()
    {
        a = 0;
        b = 0;
        c = 0;
        d = 0;
        e = 0;
        f = 1;
    }
}
