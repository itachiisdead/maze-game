using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    public static string havekey = "n";
    public static string havefriend = "n";

    void Start()
    {
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal")*6, Input.GetAxis("Vertical")*6);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag =="key")
        {
            havekey = "y";
        }
    }

    private void OnCollisionEnter2D(Collision2D door)
    {
        if((door.gameObject.tag=="door") && (havekey=="y"))
        {
            SceneManager.LoadScene("winning");
        }

    }
}
