using UnityEngine;
using UnityEngine.InputSystem;


public class BallShooter : MonoBehaviour
{
    public GameObject ball;
    public float shootForce = 700f;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; // Récupère la caméra principale
    }

    public void ShootBall(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Vector3 spawnPosition = mainCamera.transform.position + mainCamera.transform.forward * 0.5f;

            print("ShootBall called");

            // Instanciation
            GameObject ballshoot = Instantiate(ball, spawnPosition, Quaternion.identity);

            // Lancer la balle
            Rigidbody rb = ballshoot.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(mainCamera.transform.forward* shootForce);
                }
        }
    }
}
