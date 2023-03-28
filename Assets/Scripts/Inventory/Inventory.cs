using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] full_slots = new bool[5];
    public GameObject[] slots = new GameObject[5];
    private selectedWeapon selectedWeapon;
}
