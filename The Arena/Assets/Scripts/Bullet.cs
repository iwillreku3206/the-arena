using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Player player;
    public SphereCollider collider;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        collider = gameObject.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * player.bulletSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        System.Console.WriteLine("Collided with {0}", collision.gameObject);
    }
}
    