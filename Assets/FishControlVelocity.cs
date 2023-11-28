using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishControlVelocity : MonoBehaviour {
    Rigidbody2D rb;
    public float speed = 8;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed,
            Input.GetAxis("Vertical") * speed);
    }
}
