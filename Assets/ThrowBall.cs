using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    //public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject prefab = Resources.Load<GameObject>("ball");
        if (Input.GetButtonDown("Fire1"))
            Instantiate(prefab);
    }
}
