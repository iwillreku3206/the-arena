using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float health = 5f;
    public float healthMax = 5f;


    public Renderer objRenderer;


    // Start is called before the first frame update
    void Start()
    {
        objRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        objRenderer.material.color = new Color(1f, (float)(health / healthMax)/2f, 0f);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
