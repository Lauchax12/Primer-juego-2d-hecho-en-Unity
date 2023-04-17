using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    public camera d;

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.layer == 8)
        {
            d.roomC();
        }
    }
}
