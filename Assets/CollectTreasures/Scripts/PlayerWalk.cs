using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed;
    public bool endOfGame;

    // Update is called once per frame
    void Update()
    {
        if (!endOfGame)
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
    }
}
