using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPhysics2 : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 2;
    public float jumpSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            rb.velocity += Vector2.up * jumpSpeed;
        }
    }

    private void FixedUpdate() {
        // rb.velocity += Vector2.up * Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime + Vector2.right * Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        rb.velocity = Vector2.right * speed * Input.GetAxis("Horizontal") + rb.velocity.y * Vector2.up;

    }
}
