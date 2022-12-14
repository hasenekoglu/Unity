using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMovement : MonoBehaviour
{
    public GameManager gameManager;
    public Transform[] transforms;
    public float speed;


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

        var transformLength = Math.Abs(transforms[0].position.x - transforms[1].position.x);
        foreach (var subTransform in transforms)
        {
            var deltaPosition = Vector3.left * (speed * Time.deltaTime);
            subTransform.position += deltaPosition;

            if (subTransform.position.x < -68f)
            {
                subTransform.position += Vector3.right * (2 * transformLength);
            }
        }
    }
}