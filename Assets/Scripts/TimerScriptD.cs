﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScriptD : MonoBehaviour
{
    public string levelToLoad;
    public int timeLeft = 30;
    public Text countdownText;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left: " + timeLeft);

        if (timeLeft <= 0)
        {
            //Application.LoadLevel(levelToLoad);

            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";

            if (GameController.instance.gameOver != true)
            {
                SceneManager.LoadScene("Wait2D", LoadSceneMode.Single);
            }
        }

        if (GameController.instance.gameOver == true)
        {
            countdownText.text = "";
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}