using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selectedWeapon : MonoBehaviour
{
    public GameObject[] weapons = new GameObject[2];
    private Player player;
    public GameObject selectedWeaponText;

    void Start()
    {
        player = FindObjectOfType<Player>();
        selectedWeaponText.GetComponent<TextMeshProUGUI>().text = "selected weapon: sword";
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
                        selectedWeaponText.GetComponent<TextMeshProUGUI>().text = "selected weapon: wand";
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
                        selectedWeaponText.GetComponent<TextMeshProUGUI>().text = "selected weapon: sword";
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
