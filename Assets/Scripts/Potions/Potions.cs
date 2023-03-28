using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour
{
    private Player player;
    public int health_potion;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    public void HealthPotion()
    {
        player.Health(health_potion);
        Destroy(gameObject);
    }
}
