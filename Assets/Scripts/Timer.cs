﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [SerializeField]
    private Text uiText;

    [SerializeField]
    private float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

    private void Start()
    {
        timer = mainTimer;
    }

    private void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");

        }
        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
            ResetTimer();
            GameObject.FindWithTag("GameController").GetComponent<MainCard>().Restart();

        }
    }

    public void NextLvl()
    {
        if(mainTimer > 1)
        {
            timer = mainTimer-1;
            mainTimer = timer;
            Debug.Log(timer);
            canCount = true;
            doOnce = false;
        }
        else
        {
            timer = mainTimer;
            canCount = true;
            doOnce = false;
        }
    }

    public void ResetTimer()
    {
        mainTimer = 5;
        timer = mainTimer;
        canCount = true;
        doOnce = false;
    }
}
