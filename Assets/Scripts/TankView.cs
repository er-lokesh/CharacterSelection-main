using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    public Rigidbody rb;

    private float movement;
    private float rotation;

    public void SetTankController(TankController controller)
    {
        tankController = controller;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (movement != 0)
            tankController.Move(movement);

        if (rotation != 0)
            tankController.Rotate(rotation);
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }
}
