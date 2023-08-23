using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="player")
        {
            Destroy(gameObject);
        }
    }
}
