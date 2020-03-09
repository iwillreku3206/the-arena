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
    public float enemySpawnRate = 5f;

    public int score;
    public int money;
    public int kills;

    public float enemyTimer = 5f;

    public UnityEngine.Object enemy;

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
                if (enemySpawnRate > 0.5f / Time.fixedDeltaTime)
                {
                    enemySpawnRate /= 1.5f;
                }

            }

            player.bulletDamage++;

            minuteCounter = 0;

        }


        // For enemy spawn

        enemyTimer -= Time.fixedDeltaTime;
        if (enemyTimer <= 0)
        {
            Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation);
            enemyTimer = enemySpawnRate;
        }

    }

    public static void ResetGame(Game game)
    {
        /*game.player.transform.position = new Vector3(5f, -1f, 0f);
        game.player.health = 100f;

        game.enemySpeed = 1f;
        game.enemySpawnRate = 5f;

        game.score = 0;
        game.money = 0;
        game.kills = 0;

        game.enemyTimer = 5f;

        game.minuteCounter = 0;
        game.minutesPassed = 0;
        */

        Application.Quit();

    }

}
