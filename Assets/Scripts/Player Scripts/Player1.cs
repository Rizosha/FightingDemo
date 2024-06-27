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
    Vector3 direction;
    public float radius;
    public float angle = 0;
    public float moveSpeed = 2;
    public Vector3 offset;
    public Vector3 newPosition;
    public Vector3 movement;
    PlayerControls input;

    public bool isDashing;
    public float sideStepDuration;
    public float sideStepDistance;

    public Animator animator;


    void Start()
    {
        //get controller input and component
        controller = GetComponent<CharacterController>();
        input = new PlayerControls();
        input.Movement.Enable();
        input.AttackButton.Enable();

        //calculate initial angle and direction
        direction = transform.position - player2.position;
        angle = Mathf.Atan2(direction.x, direction.z);

        animator = GetComponent<Animator>();


        // This is used to play sidestep from input. This ensures that it is only played on the second tap down to "performed" as it can only be used in a += or -= 
        input.Movement.SidestepUp.performed += ctx => OnSidestepUp();
        input.Movement.SidestepDown.performed += ctx => OnSidestepDown();
    }

    void Update()
    {
        //keep updated on angle 
        radius = Vector3.Distance(player2.transform.position, transform.position);
        direction = transform.position - player2.position;
        angle = Mathf.Atan2(direction.x, direction.z);

        //----------------------------------------------------------------------------------------------
        //Old move up 

        /*
        // Get input from the user
        if (input.Movement.SidestepUp.IsInProgress())
        {
            // Move clockwise
            // angle += speed * Time.deltaTime;

            //angle += Mathf.Lerp(angle,(angle + 5f),speed) * Time.deltaTime;

            MoveAngle();

        }
        */

        // Forward and backward movement
        Vector3 forwardMovement = Vector3.zero;

        if (input.Movement.Forward.IsInProgress() && !isDashing)
        {
            forwardMovement = transform.forward * moveSpeed * Time.deltaTime;
            controller.Move(forwardMovement);
        }
        if (input.Movement.Backward.IsInProgress() && !isDashing)
        {
            forwardMovement = -transform.forward * moveSpeed * Time.deltaTime;
            controller.Move(forwardMovement);
        }

        if (input.AttackButton.Punch.IsPressed())
        {
            animator.SetBool("Punch", true);
           // animator.SetBool("Punch", false);
        }

        // Look at player 2
        transform.LookAt(new Vector3(player2.position.x, transform.position.y, player2.position.z));


        while(controller.velocity.magnitude == 0)
        {
            animator.SetBool("SidestepRight", false);
            animator.SetBool("SidestepLeft", false);
        }



    }
    
     private void OnSidestepUp()
     {
        if (!isDashing)
        {
            // This line ensures that the player only moves a set distance. Before this the player would sidestep different distances based on the radius. 
            float angleIncrement = sideStepDistance / radius;
            StartCoroutine(Sidestep(angleIncrement));

            animator.SetBool("SidestepLeft", true);
        }
     }

    private void OnSidestepDown()
    {
        if (!isDashing)
        {
            float angleIncrement = -sideStepDistance / radius;
            StartCoroutine(Sidestep(angleIncrement));

            animator.SetBool("SidestepRight", true);
        }
    }

    private IEnumerator Sidestep(float angleIncrement)
    {
        // is now dashing
        isDashing = true;

        //Set angle variable to calculate how far
        float startAngle = angle;
        float targetAngle = angle + angleIncrement;

        // Variable for how long has passed
        float elapsedTime = 0f;

        // 
        while (elapsedTime < sideStepDuration)
        {
            //calculate the angle
            angle = Mathf.Lerp(startAngle, targetAngle, elapsedTime / sideStepDuration);

            //Move
            MoveAngle();

            // start timer for sidestep
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure we reach the exact target angle
        angle = targetAngle;
        MoveAngle();
        isDashing = false;
    }

    private void MoveAngle()
    {
        // Calculate the new position around player2
        offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)) * radius;
        newPosition = player2.position + offset;
        movement = newPosition - transform.position;
        
        
        // Use CharacterController to move around player2
        controller.Move(movement);
    }


    void PunchOff()
    {
        animator.SetBool("Punch",false);
    }

    void SideOff()
    {
        animator.SetBool("SidestepLeft", false);
    }

    /*
    private IEnumerator UpDash(float angleIncrement)
    {
        isDashing = true;
        float startAngle = angle;
        float targetAngle = angle + angleIncrement;
        float elapsedTime = 0f;

        while (elapsedTime < dashDuration)
        {
            angle = Mathf.Lerp(startAngle, targetAngle, elapsedTime / dashDuration);
            MoveAngle();
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure we reach the exact target angle
        angle = targetAngle; 
        MoveAngle();
        isDashing = false;
    }

    private IEnumerator DownDash(float angleIncrement)
    {
        isDashing = true;
        float startAngle = angle;

        // this is the only difference to previous method. Will need refactoring 
        float targetAngle = angle - angleIncrement;

        float elapsedTime = 0f;

        while (elapsedTime < dashDuration)
        {
            // smooths movement to stated angle increment. 
            angle = Mathf.Lerp(startAngle, targetAngle, elapsedTime / dashDuration);

            MoveAngle();
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure we reach the exact target angle
        MoveAngle();
        angle = targetAngle;
        isDashing = false;
    }
    

    */
}
