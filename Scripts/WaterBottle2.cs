using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBottle2 : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Flower2" | collision.gameObject.name == "Trashcan")
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.name == "Trashcan")
        {
            Destroy(gameObject);
        }
        else if ((collision.gameObject.name == "Player1" | collision.gameObject.name == "Player2") && collision.gameObject.transform.GetChild(0).transform.childCount == 0)
        {
            transform.SetParent(collision.gameObject.transform.GetChild(0).transform);
            Vector3 addition = new Vector3(0, 0, 0);
            if (collision.gameObject.transform.eulerAngles.z == 90)
            {
                addition += new Vector3(-0.875f, 0, 0);
            }
            else if (collision.gameObject.transform.eulerAngles.z == 270)
            {
                addition += new Vector3(0.875f, 0, 0);
            }
            else if (collision.gameObject.transform.eulerAngles.z == 0)
            {
                addition += new Vector3(0, 0.875f, 0);
            }
            else if (collision.gameObject.transform.eulerAngles.z == 180)
            {
                addition += new Vector3(0, -0.875f, 0);
            }
            if(gameObject.name == "WaterBottle" | gameObject.name == "WaterBottle2") { transform.position = collision.transform.position; }
            else { transform.position = collision.transform.position + addition; }

                
            transform.eulerAngles = collision.gameObject.transform.eulerAngles;
        }

    }

}

