using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed = 2;
    public float maxVel = 10f;
    public float autoRSpeed = 0.1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            rb.velocity += Vector2.up * speed;
        }
    }

    private void FixedUpdate() {
        rb.velocity += Vector2.up * Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime + Vector2.right * Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        AutoRestoreRotation();
    }

    private void AutoRestoreRotation() {
        if(rb.rotation > 0) {
            rb.angularVelocity -= autoRSpeed * Time.fixedDeltaTime;
        }
        if(rb.rotation < 0) {
            rb.angularVelocity += autoRSpeed * Time.fixedDeltaTime;
        }

    }
}
