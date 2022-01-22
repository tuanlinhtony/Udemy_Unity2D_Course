using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 1f;
    [SerializeField] private float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmaount = Input.GetAxis("Horizontal") * steerSpeed;
        transform.Rotate(0,0, -steerAmaount);
        transform.Translate(0, moveSpeed, 0);
    }
}
