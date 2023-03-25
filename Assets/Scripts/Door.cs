using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float health = 10f;

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float damage)
    {
        if (health > 0)
        {
            health -= damage;
        }
    }
}
