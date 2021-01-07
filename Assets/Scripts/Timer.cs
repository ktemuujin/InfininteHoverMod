﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{

    public Text scoreText;
    private float timeElapsed = 0f;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        scoreText.text = "Time: " + FormatTime(timeElapsed);
    }

    string FormatTime(float value)
    {
        TimeSpan t = TimeSpan.FromSeconds(value);
        return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
    }
}