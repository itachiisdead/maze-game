using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycontrol : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="player")
        {
            Destroy(gameObject);
        }
    }
}
