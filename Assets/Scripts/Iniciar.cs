using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Iniciar : MonoBehaviour
{
    public Text highText;
    private GameController dataControl;
    private float score;

    public void startGame()
    {
        //Al presionar el boton "Play", se va a cargar la Scene "Principal" y va a iniciar el juego.
        SceneManager.LoadScene("MUNDO1", LoadSceneMode.Single);
    }
    void Update()
    {

    }
}
