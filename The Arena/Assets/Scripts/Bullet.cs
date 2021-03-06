﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Player player;
    public SphereCollider bulletCollider;
    
    public Game game;
    

    // Start is called before the first frame update
    void Start()
    {


        player = GameObject.Find("Player").GetComponent<Player>();
        game = GameObject.Find("Game").GetComponent<Game>();

        bulletCollider = gameObject.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * player.bulletSpeed);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemy(Clone)")
        {
            
            other.gameObject.SendMessage("TakeDamage", player.bulletDamage);
        }

        Destroy(gameObject);
    }
}
    
