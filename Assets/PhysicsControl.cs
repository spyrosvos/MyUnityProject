using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsControl : MonoBehaviour {
    Rigidbody2D rb;
    public float jumpSpeed = 5;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if(Input.GetButtonDown("Fire1")) {
            rb.velocity += new Vector2(jumpSpeed, jumpSpeed);
        }
    }
}
