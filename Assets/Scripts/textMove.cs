using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textMove : MonoBehaviour
{
    public int speedMouse = 20000;
    public int speedVertical = -500;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(0, Input.GetAxis("Mouse ScrollWheel") * speedMouse * Time.deltaTime);
        rb.velocity = new Vector2(0, Input.GetAxis("Vertical") * speedVertical * Time.deltaTime);
    }
}
