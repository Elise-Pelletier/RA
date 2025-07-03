using UnityEngine;
using UnityEngine.InputSystem;


public class BallShooter : MonoBehaviour
{
    public GameObject ball;
    public float shootForce = 10f;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    public void ShootBall(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            print(context.performed);
            // Instanciation
            //GameObject ballshoot = Instantiate(ball, transform.position, transform.rotation);

            // Lancer la balle
            //Rigidbody ballRigidbody = ballshoot.GetComponent<Rigidbody>.AddForce(mainCamera, transform.forward * shootForce, ForceMode.Im

        }
    }
}
