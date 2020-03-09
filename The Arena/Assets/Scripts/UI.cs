using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Player player;
    public Game game;

    public ProgressBar healthBar;
    public ProgressBar staminaBar;


    public Text fpsText;
    public Text scoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GameObject.Find("HealthBar").GetComponent<ProgressBar>();
        staminaBar = GameObject.Find("StaminaBar").GetComponent<ProgressBar>();

        fpsText = GameObject.Find("FPSCounter").GetComponent<Text>();
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.BarValue = (float)player.health / (float)player.maxHealth * 100;
        staminaBar.BarValue = (float)player.stamina / (float)player.maxStamina * 100;

        fpsText.text = Convert.ToString(1f / Time.smoothDeltaTime) + "FPS";
        scoreText.text = "Score: " + game.score;
    }
}
