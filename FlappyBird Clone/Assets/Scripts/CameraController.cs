using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Bird;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += new Vector3(1f*Time.deltaTime, 0, 0);
    }
}
