using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private float timeBtwAttack = 0f;
    private float startTime = 0.2f;
    private float radius = 0.5f;
    private int damage = 10;

    public Transform attackPosition;
    public LayerMask enemy;

    private void Update()
    {
        if (timeBtwAttack <= 0)
        {
            if(Input.GetMouseButton(0))
            {
                Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPosition.position, radius, enemy);
                for (int i = 0; i < enemies.Length; i++)
                {
                    if (enemies[i].CompareTag("Enemy"))
                    {
                        enemies[i].GetComponent<Enemy>().TakeDamage(damage);
                    }
                    else if (enemies[i].CompareTag("Door"))
                    {
                        enemies[i].GetComponent<Door>().TakeDamage(damage);
                    }
                }
                timeBtwAttack = startTime;
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPosition.position, radius);
    }
}
