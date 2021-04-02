using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : InteractiveObject
{
    public Light lightComponent;
    public void PointClick()
    {
        lightComponent.enabled = !lightComponent.enabled;
    }
}
