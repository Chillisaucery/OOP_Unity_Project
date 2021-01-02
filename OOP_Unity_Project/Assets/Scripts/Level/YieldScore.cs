using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YieldScore : MonoBehaviour
{

    public int score=100;

    private DisplayScore displayScore;
    private Countdown countdown;
    private GameObject player;
    private HealthControl health;

    // Start is called before the first frame update
    void Start()
    {
        displayScore = FindObjectsOfType<DisplayScore>()[0];
        countdown = FindObjectOfType<Countdown>();
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        health = player.GetComponent<HealthControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        int healthValue = (int)health.health;
        score *= healthValue / (50);

        displayScore.score += score;
    }
}
