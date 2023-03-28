using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryOpen : MonoBehaviour
{
    private GameObject Inventory;

    void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Inventory");
        Inventory.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inventory.SetActive(!Inventory.activeInHierarchy);
        }
    }

    void ActiveSet()
    {
        Inventory.SetActive(!Inventory.activeInHierarchy);
    }
}
