using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEngine.GraphicsBuffer;

public class TargetManger : MonoBehaviour

{
    private void OnCollisionEnter(Collision other)
    {
        print("Collider");
        if (other.gameObject.CompareTag("Ball") && gameObject.tag == "Target")
        {
            print("target touchée");
            CiblesManager.instance.score = CiblesManager.instance.score + 5;
            Destroy(gameObject);
        }
    }
}
