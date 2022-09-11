using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Unit
{

    float horizontalInput;

    float verticalInput;

    // Update is called once per frame
    void Update()
    {
        //speed_force = Vector2.Lerp(speed_force, Vector2.zero, 0.01f);
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        speed_force = new Vector2(horizontalInput, verticalInput) * speed_multiplayer;
        //Unit_rb.AddForce(speed_force);
        Unit_rb.velocity = speed_force;
    }
}
