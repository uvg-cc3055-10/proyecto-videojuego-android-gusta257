using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Clase de para trancision entree niveles difciles
 */
public class TimerMundo2D : MonoBehaviour
{
    public string levelToLoad;
    public int timeLeft = 5;
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
        //Trancision de nivel
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("MUNDO2D", LoadSceneMode.Single);
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