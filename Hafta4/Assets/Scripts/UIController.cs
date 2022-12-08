using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    [SerializeField] private Image left;
    [SerializeField] private Image right;
    [SerializeField] private Image mid;
    
    
    [SerializeField] private TMP_Text scoreText;
    private static int score = 0;
    private static int life = 3;
    private void Update()
    {
            UpdateScoreText();
            ControlHealtUI();
    }


    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public static void WinScore()
    {
        score++;
    }

    public static void LoseLife()
    {
        life--;
    }

    private void ControlHealtUI()
    {
        if (life == 2)
        {
            right.color = Color.black;
        }

        if (life == 1)
        {
            mid.color = Color.black;
        }

        if (life == 0)
        {
            left.color = Color.black;
            

        }
    }
    
    
}
