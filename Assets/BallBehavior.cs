using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour {
    // Start is called before the first frame update
    public float timeout = 5;
    float timer = 0;

    void Start() {
       
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if(timer > timeout) {
            Destroy(gameObject);
        }
    }

    public void SetSpeed(float speed) {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }
}
