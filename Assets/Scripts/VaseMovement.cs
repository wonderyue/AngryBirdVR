using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseMovement : InteractiveObject
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isPointEnter && Input.GetButton("Fire1"))
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.WorldToScreenPoint(gameObject.transform.position).z));
        }
    }
}
