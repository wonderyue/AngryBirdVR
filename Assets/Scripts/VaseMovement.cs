using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseMovement : MonoBehaviour
{
    Rigidbody rb;
    bool selected = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (selected && Input.GetButton("Fire1"))
        {
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.WorldToScreenPoint(gameObject.transform.position).z));
        }
    }

    public void EnbleDrag()
    {
        selected = true;
    }

    public void DisableDrag()
    {
        selected = false;
    }
}
