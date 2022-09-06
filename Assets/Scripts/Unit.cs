using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public Rigidbody2D Unit_rb;
    public Vector2 speed_force = Vector2.zero;
    public float speed_multiplayer = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed_force = Vector2.Lerp(speed_force, Vector2.zero, 0.01f); 
    }
}
