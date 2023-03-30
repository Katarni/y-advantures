using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wandInInventory : MonoBehaviour
{
    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        foreach (Transform child in transform)
        {
            if (child.tag == "slot")
            {
                foreach (Transform child_of_child in child.transform)
                {
                    if (child_of_child.tag == "Wand")
                    {
                        player.wand_unlocked = true;
                    }
                }
            }
        }
    }
}
