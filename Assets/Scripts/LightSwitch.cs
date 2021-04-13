using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    float xRotation = 64.298f;
    public static GameObject switcher;
    private static GameObject[] lights;
    bool lightOn = true;

    private void Awake()
    {
        switcher = GameObject.FindGameObjectsWithTag("Switcher")[0];
        lights = GameObject.FindGameObjectsWithTag("Lights");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateSwitcher()
    {
        if (lightOn)
        {
            switcher.transform.Rotate(xRotation, 0.0f, 0.0f, Space.Self);
            foreach(GameObject light in lights)
            {
                light.SetActive(false);
            }
        } else
        {
            switcher.transform.Rotate(-xRotation, 0.0f, 0.0f, Space.Self);
            foreach (GameObject light in lights)
            {
                light.SetActive(true);
            }
        }
        lightOn = !lightOn;
    }
}
