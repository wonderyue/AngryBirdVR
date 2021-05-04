using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookMovement : MonoBehaviour
{
    public float distance = 0.8f;
    private Vector3 initialPosition;
    private Vector3 position;

    void Start()
    {
        initialPosition = transform.position;
        position = initialPosition;
    }

    void Update()
    {
        transform.position = position;
    }

    public void move()
    {
        position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z + distance);
    }
}
