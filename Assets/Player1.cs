using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public CharacterController controller;
    public Transform player2;
    public Vector3 player1;
    public GameObject p2;
    Transform target;
    Vector3 direction;
    public float radius;
    public float angle = 0;
    public float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        Vector3 direction = transform.position - player2.position;
        angle = Mathf.Atan2(direction.x, direction.z);
    }

    // Update is called once per frame
    void Update()
    {
        radius = Vector3.Distance(p2.transform.position, transform.position);
       
        // Get input from the user
        if (Input.GetKey(KeyCode.W))
        {
            // Move clockwise
            angle += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Move counterclockwise
            angle -= speed * Time.deltaTime;
        }


        // Calculate the new position of Player 1
        Vector3 offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)) * radius;
        transform.position = player2.position + offset;

        // Optional: Make Player 1 face Player 2
        transform.LookAt(player2);
    }
}
