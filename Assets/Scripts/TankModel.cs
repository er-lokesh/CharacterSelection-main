using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public int movementSpeed;
    public int rotationSpeed;

    public TankModel(int _move, int _rotate)
    {
        movementSpeed = _move;
        rotationSpeed = _rotate;
    }

    public void SetTankController(TankController controller)
    {
        tankController = controller;
    }
}
