using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarControl : MonoBehaviour {
    public float speed = 0.5f;
    public float rotSpeed = 10f;
    public float leftLimit = 3, rightLimit = -3, upLimit = 2, downLimit = -2;

    void Update() {
        /* transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
             Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, Space.World);*/
        transform.Rotate(0, 0, rotSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(0, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0);
        if(transform.position.x > leftLimit) {
            Vector3 v = transform.position;
            v.x = leftLimit;
            transform.position = v;
        }
        if (transform.position.x < rightLimit) {
            Vector3 v = transform.position;
            v.x = rightLimit;
            transform.position = v;
        }
        if (transform.position.y > upLimit) {
            Vector3 v = transform.position;
            v.y = upLimit;
            transform.position = v;
        }
        if (transform.position.y < downLimit) {
            Vector3 v = transform.position;
            v.y = downLimit;
            transform.position = v;
        }
        if(Input.GetButtonDown("Fire1")) {
            transform.position = Input.mousePosition;
        }

        if (Input.GetButtonDown("Horizontal"))
            Debug.Log("Horizontal");
    }
}


/*Vector3 v = Input.GetAxis("Horizontal") * Vector3.right + Input.GetAxis("Vertical") * Vector3.up;
if (v.magnitude > 1)
    v.Normalize();
transform.Translate(v.x * speed * Time.deltaTime, v.y * speed * Time.deltaTime, 0);*/

/*
 * void OnMouseDown() {
        Debug.Log("someone clicked me!");
    }*/