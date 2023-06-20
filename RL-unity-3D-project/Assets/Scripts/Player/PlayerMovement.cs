using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private bool isDoingAction;
    private Vector3 goalPos;
    private float distanceToGoal;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isDoingAction = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDoingAction) 
        {
            moveForward();
        }
        else 
        {
            takeInput();
        }
    }

    void moveForward() 
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        distanceToGoal = Vector3.Distance(transform.position, goalPos);
        if (distanceToGoal <= 0.01) 
        {
            isDoingAction = false;
        }
    }

    void takeInput() 
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Go forward!");
            goalPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            isDoingAction = true;
        }
        else
        {
            isDoingAction = false;
        }
    }
}
