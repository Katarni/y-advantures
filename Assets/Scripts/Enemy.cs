using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 20f;
    private Rigidbody2D rb;
    private float speed = 0.5f;
    private GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        Move();
    }

    public void TakeDamage(float damage)
    {
        if (health > 0)
        {
            health -= damage;
        }
    }

    private void Move()
    {
        float moveX;
        float moveY;

        if (Player.transform.position.x > transform.position.x)
        {
            moveX = 1f;
        }
        else if (Player.transform.position.x < transform.position.x)
        {
            moveX = -1f;
        }
        else
        {
            moveX = 0f;
        }

        if (Player.transform.position.y > transform.position.y)
        {
            moveY = 1f;
        }
        else if (Player.transform.position.y < transform.position.y)
        {
            moveY = -1f;
        }
        else
        {
            moveY = 0f;
        }

        rb.velocity = new Vector2(moveX * speed, moveY * speed);
    }
}
