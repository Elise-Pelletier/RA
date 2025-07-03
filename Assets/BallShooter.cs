using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class BallShooter : MonoBehaviour
{
    public GameObject ball;
    private float shootForce = 5f;

    public void ShootBall(InputAction.CallbackContext context)

    {   
        if(ObjectSpawner.Instance.enableSpawn) 
            return; // Ne pas tirer si le spawn est activé

        if (context.performed)
            {
                GameObject ballshoot = Instantiate(ball, transform.position, transform.rotation);

                // Lancer la balle
                ballshoot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce, ForceMode.Impulse);

            }
    }
 
}
