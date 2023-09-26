using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float reverseMoveSpeed = 2.0f;
    [SerializeField] private float rotateSpeed = 360.0f;
    private Vector3 position;
    [SerializeField] private Vector3 _rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer() {
        // Forward and Backward movement
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * reverseMoveSpeed * Time.deltaTime);

        // Left and Right rotation
        if (Input.GetKey(KeyCode.D)) _rotation = Vector3.up;
        else if (Input.GetKey(KeyCode.A)) _rotation = Vector3.down;
        else _rotation = Vector3.zero;
        transform.Rotate(_rotation * rotateSpeed * Time.deltaTime);

    }



}
