using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 20f;
    private float timeBtwAttack = 0f;
    private float startTime = 0.2f;
    private float speed = 0.5f;
    private float damage = 5f;
    private float stopTime = 0f;
    private float startStopTime = 0.1f;
    private const float SPEED = 0.5f;

    private GameObject Player;
    private Player player;
    private Rigidbody2D rb;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        player = FindObjectOfType<Player>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (stopTime <= 0)
        {
            speed = SPEED;
        }
        else
        {
            speed = 0;
            stopTime -= Time.deltaTime;
        }

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
            stopTime = startStopTime;
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

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (timeBtwAttack <= 0)
            {
                player.TakeDamage(damage);
                timeBtwAttack = startTime;
            }
            else
            {
                timeBtwAttack -= Time.deltaTime;
            }
        }
    }
}
