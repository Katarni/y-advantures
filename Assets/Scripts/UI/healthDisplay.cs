using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthDisplay : MonoBehaviour
{
    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "health: " + player.GetHealth();
    }
}
