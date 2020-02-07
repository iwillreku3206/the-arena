using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float baseSpeed = 1.0f;
    public float runSpeed = 3f;
    public float speed = 1.0f;

    public float bulletSpeed = 5.0f;
    
    public float health = 100f;
    public float maxHealth = 100f;
    
    public float stamina = 100f;
    public float maxStamina = 100f;
    
    public bool dead = false;

    public int staminaRestoreCooldown = 0;

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
