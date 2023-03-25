using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float damage = 5f;
    private float distance = 0.5f;
    private float speed = 25f;
    private float lifeTime;

    public LayerMask solid;
    
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, solid);

        if (hitInfo.collider != null) 
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }

            if (hitInfo.collider.CompareTag("Door"))
            {
                hitInfo.collider.GetComponent<Door>().TakeDamage(damage);
            }

            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
