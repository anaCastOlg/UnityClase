using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]

public class Barco2Controler : MonoBehaviour
{
    private Rigidbody2D rb;

    private float movementX;
    private float movementY;
    public int speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movementX, movementY) * speed;
    }
}
