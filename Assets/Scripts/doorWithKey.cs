using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorWithKey : MonoBehaviour
{
    public int DoorID;

    private GameObject inventory;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory");
    }

    void Update()
    {
        foreach (Transform child in inventory.transform)
        {
            if (child.tag == "slot")
            {
                foreach (Transform child_of_child in child.transform)
                {
                    if (child_of_child.tag == "key")
                    {
                        if (child_of_child.GetComponent<KeyUI>().keyID == DoorID)
                        {
                            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                        }
                    }
                }
            }
        }
    }
}
