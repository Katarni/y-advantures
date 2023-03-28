using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float speed = 10f;
    private float health = 100f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    public void Health(float health)
    {
        this.health += health;
        if (this.health >= 100)
        {
            this.health = 100;
        }
    }

    public string GetHealth()
    {
        return health.ToString();
    }
}
