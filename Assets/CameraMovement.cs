using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{ 
    [SerializeField] GameObject playerCar;
  
    void LateUpdate()
    {
        transform.position = playerCar.transform.position + new Vector3(0,0,-10);
    }
}
