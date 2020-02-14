using UnityEngine;
using System.Collections;
using System;

public class Game : MonoBehaviour
{
    public int minutesPassed;

    int minuteCounter = 0;
    int framesPerMinute; // Using fixed update

    public Player player;

    public float enemySpeed = 1f;
    public float enemySpawnRate = 50000f;
    
    public int score;
    public int money;
    public int kills;
    
    private void FixedUpdate()
    {
        framesPerMinute = Convert.ToInt32(Math.Round(60 / Time.fixedDeltaTime));

        minuteCounter++;

        if (minuteCounter >= framesPerMinute)
        {
            minutesPassed++;
            if (minutesPassed % 2 == 1)
            {
                enemySpeed += 0.5f;
            }
            else
            {
                if (enemySpawnRate > 4 / Time.fixedDeltaTime)
                {
                    enemySpawnRate /= 1.5f;
                }
                
            }

            minuteCounter = 0;

        }
    }
}
