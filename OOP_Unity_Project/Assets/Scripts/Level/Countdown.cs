using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public GameObject textObject;
    public GameObject player;
    public int minutes = 1;
    public int seconds = 30;
    public int endgame = 0;
    public float TIMERMAX=999f;

    private float timer;
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        timer = TIMERMAX;
        text = textObject.GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {

	    text.text = "Time left: " + minutes + " : " + seconds;

    	timer -= Time.deltaTime;
        if (timer <= 0) {
	        seconds--;
	        timer = TIMERMAX;
	    }
	    if (seconds <= 0) {
	        seconds = 59;
            minutes--;
	    }
        if (minutes <0 || player == null)
        {
            Destroy(player);
            Destroy(textObject);
        }
    }
}
