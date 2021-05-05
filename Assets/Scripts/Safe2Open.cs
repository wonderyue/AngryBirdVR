using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe2Open : MonoBehaviour
{
    string codeTextValue = "";
    public string key = "2527";
    bool open = false;
    public GameObject door;
    public GameObject hint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddDigit(string digit)
    {
        if (!open)
        {
            if (codeTextValue.Length >= 4)
            {
                codeTextValue = "";
            }
            codeTextValue += digit;
        }
    }

    public void Clear()
    {
        if (!open)
        {
            codeTextValue = "";
        }
    }

    public void Enter()
    {
        if (!open)
        {
            if (codeTextValue == key)
            {
                open = true;
                door.transform.rotation = Quaternion.Euler(0f, -20f, 0f);
            }
            else
            {
                codeTextValue = "";
            }
        }
    }

    public void Hint()
    {

        hint.SetActive(true);

    }
}