using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float playerSpeed = 10f;
    Vector2 movement;
    public Rigidbody2D rb;
    
    void Start()
    {
        
    }
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        Rotate();

    }

    

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.deltaTime * playerSpeed);
    }



    private void Rotate()
    {
        if (movement.x == 1f & (transform.eulerAngles.z != 270))
        {
            transform.Rotate(0, 0, 270 - transform.eulerAngles.z);
        }
        else if (movement.x == -1f & (transform.eulerAngles.z != 90))
        {
            transform.Rotate(0, 0, 90 - transform.eulerAngles.z);
        }

        if (movement.y == -1 & (transform.eulerAngles.z != 180))
        {
            transform.Rotate(0, 0, 180 - transform.eulerAngles.z);
        }
        else if (movement.y == 1 & (transform.eulerAngles.z != 0))
        {
            transform.Rotate(0, 0, 0 - transform.eulerAngles.z);
        }

    }

}
