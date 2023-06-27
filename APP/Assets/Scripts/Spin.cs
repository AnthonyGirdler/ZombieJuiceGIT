using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] public float spinSpeed = 10;
    [SerializeField] Vector3 rotationDirection = new Vector3();
    void Update()
    {
        transform.Rotate(spinSpeed * rotationDirection * Time.deltaTime);
    }
}
