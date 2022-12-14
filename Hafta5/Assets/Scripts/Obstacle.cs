using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameManager gameManager;
    public float speed;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (gameManager.isGameOver)
        {
            return;
        }
        transform.position += Vector3.left * (speed * Time.deltaTime);

        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}