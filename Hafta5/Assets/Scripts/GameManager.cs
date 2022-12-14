using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public SceneController sceneController;
   public bool isGameOver;


   public void GameOver()
   {
      isGameOver = true;
      sceneController.OpenGameOverPanel();
   }
}
