using UnityEngine;

public class Projectile : MonoBehaviour
{
    // TODO : Ajuster vitesse
    private float speed = 10.0f;
    private Vector2 targetPosition;

    void Start()
    {

    }

    void Update()
    {
    }

    public void setTarget(Vector2 target)
    {
        targetPosition = target;
    }

    void goToTarget()
    {
        float maxDistance = speed * Time.deltaTime;

        // TODO : decommenter
        //transform.position = Vector2.MoveTowards(transform.position, targetPosition, maxDistance);
    }
}
