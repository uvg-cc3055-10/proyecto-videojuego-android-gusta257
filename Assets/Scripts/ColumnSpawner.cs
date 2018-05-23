using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Clase con el spawn de enemigos nivel 1*/
public class ColumnSpawner : MonoBehaviour
{

    public GameObject column;
    public float spawnTime = 4f;
    public float elapsedTime = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GameController.instance.gameOver == false)
        {
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, -1.93f);
                if (column != null)
                    Instantiate(column, new Vector3(9, random, 0), Quaternion.identity);

                elapsedTime = 0;
            }
        }
    }
}
