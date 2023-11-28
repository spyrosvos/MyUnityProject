using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishControlAcceleration : MonoBehaviour {
    Rigidbody2D rb;
    public float acc = 8;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.velocity += new Vector2(
            Input.GetAxis("Horizontal") * acc * Time.fixedDeltaTime,
            Input.GetAxis("Vertical") * acc * Time.fixedDeltaTime);
    }
}
