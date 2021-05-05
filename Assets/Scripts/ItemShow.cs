using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShow : MonoBehaviour
{
    public GameObject item;
    public Light lightComp;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (item.activeSelf == lightComp.enabled)
            item.SetActive(!lightComp.enabled);
    }
}
