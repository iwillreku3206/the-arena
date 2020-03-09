using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public float health = 5f;
    public float healthMax = 5f;

    public Renderer objRenderer;

    public Player player;
    public Game game;

    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        objRenderer = gameObject.GetComponent<Renderer>();
        player = GameObject.Find("Player").GetComponent<Player>();
        game = GameObject.Find("Game").GetComponent<Game>();
        
        agent = GetComponent<NavMeshAgent>();
        agent.speed = game.enemySpeed;

    }

    // Update is called once per frame
    void Update()
    {
        objRenderer.material.color = new Color(1f, (float)(health / healthMax)/2f, 0f);

        agent.destination = player.transform.position;

        if (health <= 0)
        {
            game.score += game.minutesPassed + 1;
            game.money += game.minutesPassed;
            game.kills++;

            Destroy(gameObject);


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
            player.health--;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
