using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 position = new Vector2(player.position.x - 0.5f, player.position.y - 0.5f);
        Instantiate(item, position, Quaternion.identity);
    }
}
