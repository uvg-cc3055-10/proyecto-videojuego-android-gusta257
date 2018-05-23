using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Spawner del prefab del tiburon facil*/
public class shark : MonoBehaviour
{

    public float scrollingSpeed = 6f;

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
