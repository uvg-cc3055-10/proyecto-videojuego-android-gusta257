using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamD : MonoBehaviour
{

    private float scrollingSpeed = 20f;

    void Start()
    {

    }

    void Update()
    {
        if (GameController.instance.gameOver != true)
        {
            transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);
            if (transform.position.x < -10)
            {
                Destroy(gameObject);
            }
        }

    }
}
