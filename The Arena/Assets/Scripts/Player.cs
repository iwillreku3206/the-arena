using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float bulletSpeed = 5.0f;
    
    public int health = 100;
    public int maxHealth = 100;
    
    public int stamina = 100;
    public int maxStamina = 100;
    
    public bool dead = false;
    
    void Update() {
        if (health > maxHealth) {
            health = maxHealth;
        }
        if (0 > health) {
            dead = true;
        }
        if (stamina > maxStamina) {
            stamina = maxStamina
        }
        if (0 > stamina) {
            stamina = 0
        }
    }

}
