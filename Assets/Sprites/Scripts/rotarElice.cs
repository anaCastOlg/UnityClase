using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotarElice : MonoBehaviour
{

    [SerializeField] int speedElice = 60;
    [SerializeField] float rotacionHelice = 60.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speedElice * Time.deltaTime);
    }
}
