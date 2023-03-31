using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float speed = 10f;
    private float health = 100f;
    Rigidbody2D rb;

    public bool wand_unlocked = false;
    private GameObject InventoryObject;
    private GameObject Respawn;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InventoryObject = GameObject.FindGameObjectWithTag("Inventory");
        Respawn = GameObject.FindGameObjectWithTag("Respawn");
    }

    private void Update()
    {
        if (health <= 0)
        {
            
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

    private void dead()
    {
        foreach (Transform child in InventoryObject.transform)
        {
            if (child.CompareTag("slot"))
            {
                if (child.childCount > 0)
                {
                    child.GetComponent<Slot>().DropItem();
                }
            }
        }
        transform.Translate(Respawn.transform.position);
        SceneManager.LoadScene("DeathScene");
    }
}
