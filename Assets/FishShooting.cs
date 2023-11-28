using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishShooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    Transform spawn;
    // Start is called before the first frame update
    void Start() {
        spawn = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        if (Input.GetButtonDown("Fire1")) {
            GameObject newBullet = Instantiate(bullet, spawn.position, spawn.rotation);
            newBullet.GetComponent<BallBehavior>().SetSpeed(-10);
        }
    }
}
