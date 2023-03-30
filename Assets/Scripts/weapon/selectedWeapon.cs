using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectedWeapon : MonoBehaviour
{
    public GameObject[] weapons = new GameObject[2];
    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                if (weapons[i].activeInHierarchy)
                {
                    if (weapons[i].CompareTag("Sword") && player.wand_unlocked)
                    {
                        weapons[i].SetActive(false);

                        if (i != weapons.Length - 1)
                        {
                            weapons[i + 1].SetActive(true);
                        }
                        else
                        {
                            weapons[0].SetActive(true);
                        }
                        break;
                    }
                    else if (weapons[i].CompareTag("Wand"))
                    {
                        weapons[i].SetActive(false);

                        if (i != weapons.Length - 1)
                        {
                            weapons[i + 1].SetActive(true);
                        }
                        else
                        {
                            weapons[0].SetActive(true);
                        }
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
