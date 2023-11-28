using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTransforms : MonoBehaviour {
    public float rotSpeed = 12f;
    void Update() {
        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
        if (Input.GetButtonDown("Fire1")) {
            Vector3 v = transform.position;
            Debug.Log("x=" + v.x);
        }
        if(Input.GetButtonDown("Fire2")) {
            Vector3 v = transform.position;
            v.x = 0;
            transform.position = v;
        }
    }
}
