using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    static public Movement S;

    [SerializeField] private float speed;

    private Rigidbody rb;
    private Vector3 direction;
    private Vector3 startPos;

    private void Start()
    {
        S = this;
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    private void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        direction = new Vector3(xAxis, 0, zAxis);
    }

    private void FixedUpdate()
    {
        rb.AddForce(direction * speed, ForceMode.Force);
    }

    public void BackToStartPosition()
    {
        transform.position = startPos;
        rb.Sleep();
    }
}
