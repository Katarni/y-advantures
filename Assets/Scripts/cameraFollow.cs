using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public float Speed;
    public GameObject Player;
    public GameObject Camera;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        Speed = 5;
    }

    void FixedUpdate()
    {
        Vector3 target = new Vector3()
        {
            x = Player.transform.position.x,
            y = Player.transform.position.y,
            z = Player.transform.position.z - 10,
        };
        Camera.transform.position = Vector3.Lerp(Camera.transform.position, target, Speed * Time.fixedDeltaTime);
    }
}
