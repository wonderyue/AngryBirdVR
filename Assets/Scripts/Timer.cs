using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timerText;
    private TextMesh textObject;
    private float startTime;
    private float elapsedTime = 0f;
    private TimeSpan timePlaying;
    private bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        textObject = timerText.GetComponent<TextMesh>();
        startTime = Time.time;
        textObject.text = "Time: 00:00:00";
    }

    // Update is called once per frame
    void Update()
    {
        if (!finished)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            textObject.text = "Time: " + timePlaying.ToString("hh':'mm':'ss");
        }
    }

    public void Finish()
    {
        finished = true;
        textObject.color = Color.yellow;
    }
}
