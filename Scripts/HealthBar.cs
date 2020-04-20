using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public FlowerScript flowerScript;
    

    void Update()
    {
        
        if(slider.value > 0)
        {
            slider.value -= Time.deltaTime;
        } else
        {
            SceneManager.LoadScene(2);
        }
    }

 


}
