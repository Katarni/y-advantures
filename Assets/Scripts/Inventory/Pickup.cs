using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject slot;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (!inventory.full_slots[i])
                {
                    inventory.full_slots[i] = true;
                    Instantiate(slot, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
