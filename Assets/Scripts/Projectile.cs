using UnityEngine;

public class Projectile : MonoBehaviour
{
    // TODO : Ajuster vitesse
    private float speed = 10.0f;

    void Start()
    {

    }

    void Update()
    {
    }

    public void goToTarget(Vector2 target)
    {
        float maxDistance = speed * Time.deltaTime;
        
        transform.position = Vector2.MoveTowards(transform.position, target, maxDistance);
    }
}
