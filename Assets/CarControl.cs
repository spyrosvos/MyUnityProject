using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour {
    public float acc = 10;
    public float rotSpeed = 50;
    Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();   
    }

    void FixedUpdate() {
        rb.rotation -= Input.GetAxis("Horizontal") * rotSpeed * Time.fixedDeltaTime;
        rb.velocity += (Vector2) transform.up * Input.GetAxis("Vertical") * acc * Time.fixedDeltaTime;
    }
}
