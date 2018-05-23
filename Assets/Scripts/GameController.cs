using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Clae con gameCotroller*/
public class GameController : MonoBehaviour {
    public bool gameOver = false;
    public int score = 0;
    public static GameController instance;
    

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
