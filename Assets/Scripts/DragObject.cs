using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Rigidbody rb;
    bool drag = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (drag)
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.WorldToScreenPoint(gameObject.transform.position).z));
        }
    }

    public void EnbleDrag()
    {
        if (Input.GetButton("Fire1"))
        {
            drag = true;
            rb.isKinematic = true;
        }
    }

    public void DisableDrag()
    {
        drag = false;
        rb.isKinematic = false;
    }
}