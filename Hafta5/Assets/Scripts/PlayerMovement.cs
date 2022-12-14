using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerSound sound;
    public ParticleSystem runParticle;
    public ParticleSystem dieParticle;
    public Rigidbody body;
    public float jumpForce;
    public PlayerAnimator playerAnimator;
    public GameManager gameManager;
    public GameObject player;
    private void Start()
    {
        playerAnimator.Run();
        runParticle.Play();
    }

    private void Update()
    {
        
        Jump();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Obstacle obstacle))
        {
           Die();
        }
    }

    private void Jump()
    {
        if (gameManager.isGameOver)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space) && player.transform.position.y < 4f)
        {
            body.AddForce(0f,jumpForce,0f,ForceMode.Impulse);
            playerAnimator.Jump();
            sound.PlayRandomJumpSFx();
        }
    }

    private void Die()
    {
        gameManager.GameOver();
        playerAnimator.Die();
        dieParticle.Play();
        runParticle.Stop();
        sound.PlayRandomDieSFx();
    }
}
