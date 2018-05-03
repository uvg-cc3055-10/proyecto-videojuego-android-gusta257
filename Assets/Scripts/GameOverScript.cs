using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public string levelToLoad;
    public int timeLeft = 100;
    public Text countdownText;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameController.instance.gameOver == true)
        {
            countdownText.text = "GAME OVER";
        }
    }

 
}