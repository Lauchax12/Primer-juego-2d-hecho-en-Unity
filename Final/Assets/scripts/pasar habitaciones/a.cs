using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    public camera c;

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.layer == 8)
        {
            c.roomA();
        }
    }
}
