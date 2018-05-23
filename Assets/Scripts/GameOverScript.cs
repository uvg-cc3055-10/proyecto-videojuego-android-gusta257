using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*Clase que controla si el jugador gana el juego*/
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
        //countdownText.text = ("" + timeLeft);

        if (GameController.instance.gameOver == true)
        {
            //countdownText.text = "GAME OVER";
            SceneManager.LoadScene("MENU", LoadSceneMode.Single);
        }

        if (timeLeft <= 0)
        {
            countdownText.text = "GANADOR!!!";
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