using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Game game;

    public float baseSpeed = 1f;
    public float runSpeed = 10f;
    public float speed = 1f;

    public float bulletSpeed = 5f;
    
    public float health = 100f;
    public float maxHealth = 100f;
    
    public float stamina = 100f;
    public float maxStamina = 100f;
    
    public bool dead = false;

    public float bulletDamage = 2.5f;

    public int staminaRestoreCooldown = 0;


    // Start of game stats
    public int kills = 0;
    public int score = 0;

    void Update() {
        if (health > maxHealth) {
            health = maxHealth;
        }
        if (0 > health) {
            dead = true;
        }
        if (stamina > maxStamina) {
            stamina = maxStamina;
        }
        if (0 > stamina) {
            stamina = 0;
        }

        if (dead)
        {
            Game.ResetGame(game);
        }
    }

    private void FixedUpdate()
    {
        if (speed == runSpeed)
        {
            staminaRestoreCooldown = 200;
        }

        staminaRestoreCooldown--;

        if (staminaRestoreCooldown <= 0)
        {
            stamina++;
        }
    }





}
