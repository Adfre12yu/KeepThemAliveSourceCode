using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public bool isInGrabRange;
    public WaterDispenser2 waterDispenser;
    bool carry = false;
    public Sprite[] sprites;
    Transform child;
    Rigidbody2D childRB;
    void Start()
    {
        child = transform.GetChild(0);
        GetComponent<SpriteRenderer>().sprite = sprites[0];
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Period) && isInGrabRange && child.childCount == 0)
        {

            waterDispenser.Dispense();
        }
        if (Input.GetKeyDown(KeyCode.Comma) && carry)
        {
            childRB = child.GetChild(0).GetComponent<Rigidbody2D>();
            childRB.bodyType = RigidbodyType2D.Dynamic;
            child.GetChild(0).GetComponent<BoxCollider2D>().isTrigger = false;
            child.GetChild(0).transform.SetParent(null);

            if (this.transform.eulerAngles.z == 90)
            {
                childRB.velocity += new Vector2(-6, 0);
            }
            else if (this.transform.eulerAngles.z == 270)
            {
                childRB.velocity += new Vector2(6, 0);
            }
            else if (this.transform.eulerAngles.z == 0)
            {
                childRB.velocity += new Vector2(0, 6);
            }
            else if (this.transform.eulerAngles.z == 180)
            {
                childRB.velocity += new Vector2(0, -6);
            }
        }

        if (child.childCount > 0)
        {
            carry = true;
            childRB = child.GetChild(0).GetComponent<Rigidbody2D>();
            childRB.bodyType = RigidbodyType2D.Kinematic;
            childRB.velocity = Vector2.zero;
            childRB.angularVelocity = 0;
            child.GetChild(0).GetComponent<BoxCollider2D>().isTrigger = true;
            
        }
        else
        {
            carry = false;
        }
        ChangeSprite();
        if (childRB != null)
        {
            if (childRB.velocity.x > 0 | childRB.velocity.y > 0)
            {
                childRB.velocity *= 0.996f;


            }
        }
        void ChangeSprite()
        {
            if (carry)
            {
                GetComponent<SpriteRenderer>().sprite = sprites[1];
            }
            else { GetComponent<SpriteRenderer>().sprite = sprites[0]; }
        }
    }
    void ChangeSprite()
    {
        if (carry)
        {
            GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
        else { GetComponent<SpriteRenderer>().sprite = sprites[0]; }
    }



}






    

