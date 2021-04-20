using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerOpen : MonoBehaviour
{
    public float distance = 0.8f;
    private bool opened;
    private bool enable;
    private bool selected;
    private Vector3 initialPosition;
    private Vector3 position;


    // Start is called before the first frame update
    void Start()
    {
        opened = false;
        enable = false;
        selected = false;
        initialPosition = transform.position;
        position = initialPosition;
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = position;
    }

    public void HasKey()
    {
        enable = true;
    }

    public void Open()
    {
        if (enable)
        {
            if (!opened)
            {
                position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z + distance);
                opened = true;
            }
            else
            {
                position = initialPosition;
                opened = false;
            }
        }
    }
}