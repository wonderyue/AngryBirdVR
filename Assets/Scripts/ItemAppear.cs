using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class ItemAppear : MonoBehaviour
{
    
    public GameObject Panel;
    public GameObject GoldKey;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseDown()
    {
        GoldKey.SetActive(false);
        Panel.SetActive(true);
    }
        
  

    
}
