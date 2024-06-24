using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    public CharacterController controller;
    public Transform player2;
    public Vector3 player1;
    public GameObject p2;
    Vector3 direction;
    public float radius;
    public float angle = 0;
    public float speed = 1;
    public float moveSpeed = 2;
    public Vector3 offset;
    public Vector3 newPosition;
    public Vector3 movement;
    PlayerControls input;
    

    void Start()
    {
        //get controller input and component
        controller = GetComponent<CharacterController>();
        input = new PlayerControls();
        input.Movement.Enable();

        //calculate initial angle and direction
        direction = transform.position - player2.position;
        angle = Mathf.Atan2(direction.x, direction.z);
    }

    void Update()
    {
        //keep updated on angle 
        radius = Vector3.Distance(player2.transform.position, transform.position);
        direction = transform.position - player2.position;
        angle = Mathf.Atan2(direction.x, direction.z);

        // Get input from the user
        if (input.Movement.SidestepUp.IsInProgress())
        {
            // Move clockwise
            angle += speed * Time.deltaTime;

            MoveAngle();

            // Use CharacterController to move around player2
            controller.Move(movement);
        }
        if (input.Movement.SidestepDown.IsPressed())
        {
            // Move counterclockwise
            angle -= speed * Time.deltaTime;

            MoveAngle();

            // Use CharacterController to move around player2
            controller.Move(movement);
        }

        // Forward and backward movement
        Vector3 forwardMovement = Vector3.zero;

        if (input.Movement.Forward.IsInProgress())
        {
            forwardMovement = transform.forward * moveSpeed * Time.deltaTime;
            controller.Move(forwardMovement);
        }
        if (input.Movement.Backward.IsInProgress())
        {
            forwardMovement = -transform.forward * moveSpeed * Time.deltaTime;
            controller.Move(forwardMovement);
        }

        // Look at player 2
        transform.LookAt(new Vector3(player2.position.x, transform.position.y, player2.position.z));
    }

    private void MoveAngle()
    {
        // Calculate the new position around player2
        offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)) * radius;
        newPosition = player2.position + offset;
        movement = newPosition - transform.position;
    }
}
