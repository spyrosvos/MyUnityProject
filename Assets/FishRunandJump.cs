using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishRunandJump : MonoBehaviour {
    public float speed = 8;
    public float jumpSpeed = 10;
    Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (Input.GetButtonDown("Fire1")) {
            rb.velocity += new Vector2(0, jumpSpeed);
        }
    }

    void FixedUpdate() {
        Vector2 v = rb.velocity;
        v.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = v;
    }
}
