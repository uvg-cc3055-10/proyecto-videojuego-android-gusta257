using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    public string levelToLoad;
    public int timeLeft = 1000;
    public Text countdownText;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("" + timeLeft);

        if (GameController.instance.gameOver == true)
            {
            timeLeft = 0;
           
            }

        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("MENU", LoadSceneMode.Single);
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