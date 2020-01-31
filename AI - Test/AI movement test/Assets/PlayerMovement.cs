using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Rigidbody2D Rb;
    public Animator Animat;

    private Vector2 _movement;
    // Update is called once per frame
    void Update()
    {
        //user input

        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        Animat.SetFloat("Horizontal",_movement.x);
        Animat.SetFloat("Vertical", _movement.y);
        Animat.SetFloat("Speed",_movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        //player _movement

        Rb.MovePosition(Rb.position + _movement * MoveSpeed * Time.fixedDeltaTime);


    }
}
