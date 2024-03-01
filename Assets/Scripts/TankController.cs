using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private TankModel model;

    private Rigidbody rb;

    public TankController(TankModel _model, TankView _view)
    {
        tankModel = _model;
        tankView = GameObject.Instantiate<TankView>(_view);

        rb = tankView.GetRigidBody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

    }

    public void Move(float movement)
    {
        rb.velocity = tankView.transform.forward * movement * tankModel.movementSpeed;
    }

    public void Rotate(float rotate)
    {
        Vector3 vector = new Vector3(0, rotate * tankModel.rotationSpeed, 0);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
