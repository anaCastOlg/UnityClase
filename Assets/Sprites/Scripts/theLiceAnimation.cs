using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theLiceAnimation : MonoBehaviour
{
    [SerializeField] float rotacionHelice = 640.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, -rotacionHelice) * Time.deltaTime);
    }
}
