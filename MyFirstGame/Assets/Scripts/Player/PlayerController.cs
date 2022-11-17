using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticallInput;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;
    
    
    
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticallInput = Input.GetAxis("Vertical");
        
        
        
        
        
        transform.Translate(Vector3.forward * (speed * Time.deltaTime*verticallInput) );
        transform.Rotate(Vector3.up,turnSpeed * Time.deltaTime*horizontalInput*verticallInput);


        if (transform.position.y < -6)
        {
            loseScreen.SetActive(true);
          
        }
        else if (transform.position.z > 385)
        {
            winScreen.SetActive(true);
            
        }
        
        



    }

   public void PlayAgain()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(0,0,0);
        
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
}
