﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PajaroSpwner : MonoBehaviour
{

    public GameObject column;
    public float spawnTime = 2f;
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
                float random = Random.Range(3f, 4f);
                if (column != null)
                    Instantiate(column, new Vector3(4, random, 0), Quaternion.identity);

                elapsedTime = 0;
            }
        }
    }
}
