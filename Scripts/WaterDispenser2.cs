using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDispenser2 : MonoBehaviour
{
    public player2 playerScript;
    public GameObject wbPrefab;
    public Transform grabberTransform;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerScript.isInGrabRange = true;
        playerScript.waterDispenser = GetComponent<WaterDispenser2>();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerScript.isInGrabRange = false;
        playerScript.waterDispenser = null;
    }

    public void Dispense()
    {
        GameObject wb = Instantiate(wbPrefab, grabberTransform, false);
    }

}
