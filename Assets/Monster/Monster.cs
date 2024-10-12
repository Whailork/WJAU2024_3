using UnityEngine;

namespace Monster
{
    public class Monster : MonoBehaviour
    {
        // Variables
        public int life;
        public int power;
        public bool sleep;
        public bool electric;
        public bool dark;
        public Vector2 targetPosition;

        // TODO : Ajuster vitesse
        public float speed = 500.0f;
        public Vector2 velocity;

        // Start is called before the first frame update
        void Start()
        {
            GetComponent<Animator>().SetBool("Electric", electric);

            MapManager.mapManager.setList();
        }

        protected void goToTarget(Vector2 target)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            float speed = GetComponent<Rigidbody2D>().velocity.magnitude;
            GetComponent<Animator>().SetFloat("Speed", speed);
            GetComponent<Animator>().SetBool("Sleep", sleep);
            GetComponent<Animator>().SetInteger("Life", life);
            GetComponent<Animator>().SetBool("Dark", dark);
        }

        public int updateTargetPoint(int nextPoint)
        {
            float distance = Vector2.Distance(transform.position, targetPosition);

            if (distance <= 0.1)
            {
                nextPoint++;
                targetPosition = MapManager.mapManager.transform.position;
            }
   
            return nextPoint;
        }
 public void IsDead()
    {
        if (life <= 0)
        {
            //Monster.Destroy();
        }
    }

        public int GetPower() { return power; }

        public int GetLife() { return life; }

        public int DamageLife(int attack)
        {
            life -= attack;
            return life;
         }
    }
}