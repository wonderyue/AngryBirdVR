using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Rigidbody rb;

    private Vector3 mOffset;

    private float mZCoord;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    public void OnMouseDrag()
    {
        Vector3 move = GetMouseWorldPos() + mOffset;
        transform.position = new Vector3 (move.x, Mathf.Clamp(move.y, 0f, 28.0f), move.z);
        rb.isKinematic = true;
    }

    public void OnMouseUp()
    {
        rb.isKinematic = false;
    }
}
