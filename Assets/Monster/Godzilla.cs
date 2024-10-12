using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Godzilla : Monster
{

    //public Godzilla() { life = 100; power = 20; sleep = false; electric = false; }

    // Variables
    int nextPoint;
    Vector2 targetPosition;

    // References
    Godzilla godzillaInstance;


    // Start is called before the first frame update
    void Start()
    {
        electric = false;

        Debug.Log("Godzilla start");

        //MapManager.mapManager.getPath();

        // Projectile projectileInstance = Instantiate(projectile, transform.position, Quaternion.identity);
        // projectileInstance.goToTarget(targetMonster.transform.position);

        nextPoint = 0;
        //targetPosition

        targetPosition = MapManager.mapManager.pointsRepere[0];
        godzillaInstance = Instantiate(this, transform.position, Quaternion.identity);
        move();
    }

    void Update()
    {
        updateTargetPoint();
    }

    protected void goToTarget(Vector2 target)
    {
        float maxDistance = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, maxDistance);
    }

    private void move()//OnAnimatorMove()
    {
        godzillaInstance.goToTarget(targetPosition);
    }

    private void updateTargetPoint()
    {
        float distance = Vector2.Distance(transform.position, targetPosition);

        if (distance <= 0.25)
        {
            nextPoint++;
            targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
            //move();
        }
    }

    /*
    void AEntityCharacter::MoveTo(FVector Location)
    {
        MovementComponent->AddInputVector(Location);
    }

    FVector AEntityCharacter::Seek(FVector Target)
    {
        FVector DesiredVelocity = Target - GetActorLocation();
        DesiredVelocity.Normalize();
        DesiredVelocity *= MovementComponent->GetMaxSpeed();

        FVector Steering = DesiredVelocity - MovementComponent->Velocity;
        Steering = Steering.GetClampedToMaxSize(MovementComponent->GetMaxSpeed());

        return Steering;
    }
    */

    public float maxSpeed = 10f; // Vitesse maximale de l'entité
    public Vector2 velocity;     // Vitesse actuelle de l'entité (à remplacer par ton propre composant de mouvement si besoin)

    public Vector2 Seek(Vector3 target)
    {
        Vector2 desiredVelocity = target - transform.position;
        desiredVelocity.Normalize();
        desiredVelocity *= maxSpeed;

        Vector3 steering = desiredVelocity - velocity;
        steering = Vector2.ClampMagnitude(steering, maxSpeed);

        return steering;
    }


    //public void IfMove()
    //{
    //    if (position.x != 0 || position.y != 0)
    //    {
    //        GodAnimateMove();
    //    }
    //}

    public void IfSleep()
    {
        if (sleep == true)
        {
            GodAnimateSleep();
            sleep = false;
        }
    }

    public void IfLifeZero()
    {
        if (life == 0)
        {
            GodAnimateDead();
        }
    }

    public void GodAnimateMove()
    {

    }

    public void GodAnimateSleep()
    {

    }

    public void GodAnimateDead()
    {

    }



}
