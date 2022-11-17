using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private Vector3 offset;
    


   
    void Update()
    {
        transform.position = _playerController.transform.position + offset;

    }
}
