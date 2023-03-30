using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 20f;
    private float timeBtwAttack = 0f;
    private float startTime = 0.5f;
    private float speed = 0.5f;
    private float damage = 3f;
    private const float SPEED = 0.5f;
    public float radius = 0.5f;

    private GameObject Player;
    private Player player;
    private Rigidbody2D rb;
    public Transform attackPosition;
    public LayerMask playerLayer;

    public GameObject dropIfDie;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        player = FindObjectOfType<Player>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (health <= 0)
        {
            if (dropIfDie != null)
            {
                Vector2 position = new Vector2(transform.position.x, transform.position.y);
                Instantiate(dropIfDie, position, Quaternion.identity);
            }
            Destroy(gameObject);
        }

        if (timeBtwAttack <= 0)
        {
            Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPosition.position, radius, playerLayer);
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].GetComponent<Player>().TakeDamage(damage);
            }
            timeBtwAttack = startTime;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
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
