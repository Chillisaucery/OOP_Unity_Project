using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour
{

    public HealthControl health;
    public float delay;
    public float unit = 0.2f;

    private Slider healthDisplay;
    private float timer=0f;
    

    private void Start()
    {
        healthDisplay = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {

            if (healthDisplay.value > health.health)
            {
                healthDisplay.value = healthDisplay.value - unit;
            }


            if (healthDisplay.value < health.health)
            {
                healthDisplay.value = healthDisplay.value + unit;
            }

            timer = 0;
        }


    }
}
