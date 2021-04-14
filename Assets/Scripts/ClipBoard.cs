using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class ClipBoard : MonoBehaviour
{

    public GameObject Clipboard;
    // Start is called before the first frame update
    void Start()
    {

      
    }
    void OnMouseDown()
    {
        Clipboard.SetActive(false);
        


    }
}