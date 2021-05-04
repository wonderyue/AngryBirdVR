using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTurnSingle : MonoBehaviour
{
    public GameObject light;

    public void LightOn()
    {
        {
            if (light.activeSelf)
            {
                light.SetActive(false);
            }
            else
            {
                light.SetActive(true);
            }
        }
    }
}
