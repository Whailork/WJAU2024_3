using UnityEditor;
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
        public Rigidbody2D rb;

        // TODO : Ajuster vitesse
        public Vector2 move =new Vector2(10f, 0f);
        public Vector2 velocity;

        void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("CollisionEnter_monster");
        }

        // Start is called before the first frame update
        void Start()
        {
            MapManager.mapManager.setList();
            GetComponent<Rigidbody2D>().velocity = move;
            Debug.Log("Monstre qui start");
        }

        protected void goToTarget(Vector2 target)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime);
        }

        void Update()
        {
            //IsDead();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            
            float speed = GetComponent<Rigidbody2D>().velocity.magnitude;
            GetComponent<Animator>().SetFloat("Speed", speed);
            GetComponent<Animator>().SetBool("Sleep", sleep);
            GetComponent<Animator>().SetInteger("Life", life);
            GetComponent<Animator>().SetBool("Dark", dark);
            GetComponent<Animator>().SetBool("Electric", electric);
            IsDead();
        }

        public int updateTargetPoint(int nextPoint)
        {
            float distance = Vector2.Distance(transform.position, targetPosition);

            if (distance <= 0.1)
            {
                nextPoint++;
                targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
            }
   
            return nextPoint;
        }



        public void IsDead()
        {
            if (life <= 0)
            {
                Destroy(gameObject);
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