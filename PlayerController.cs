using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 700.0f;
    public static float distance = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.rigid2D.gravityScale = 7;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            this.rigid2D.gravityScale = 3;
        }  
    }

    /*void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "floor")
        {
            this.rigid2D.AddForce(transform.up * 0);
            //this.transform.position = new Vector3(-9, -2, 0);
            this.rigid2D.velocity.y = 0f
        }
    }*/
}
