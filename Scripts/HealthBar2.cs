using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar2 : MonoBehaviour
{
    public Slider slider;
    public FlowerScript2 flowerScript;

    
    void Update()
    {
        
        if (slider.value > 0)
        {
            slider.value -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }


}
