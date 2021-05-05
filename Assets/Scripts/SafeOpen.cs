using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeOpen : MonoBehaviour
{
    string codeTextValue = "";
    public string key = "1234";
    bool open = false;
    public GameObject door;
    public GameObject hint;
    public GameObject book;

    public AudioClip Sound;  //assign sound to play
    private AudioSource source;   //use AudioSource to play AudioClip

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();  //get the AudioSource Component of this Object
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
                book.SetActive(true);
                source.PlayOneShot(Sound, 1F);   //play sound

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
