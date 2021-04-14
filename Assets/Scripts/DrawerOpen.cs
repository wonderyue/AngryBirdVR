using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerOpen : MonoBehaviour
{
    public float speed = 12f;
    private float speed0 = 0f;
    private bool boxOpened;
    private bool coroutineAllowed;


    // Start is called before the first frame update
    void Start()
    {
        boxOpened = false;
        coroutineAllowed = true;
      
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetButton("Fire1"))
        {
            
                transform.Translate(Vector3.down * speed0 * Time.deltaTime);
      
        }

    }

    public void MoveForward()
    {
        speed0 = speed;
    }

    public void Stop()
    {
        speed0 = 0f;
    }

}