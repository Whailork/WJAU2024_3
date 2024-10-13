using UnityEngine;

namespace Monster
{
   
    public class Monster : MonoBehaviour
    {
        public int amountToAdd;
        
        // Variables
        public int life;
        public int power;
        public bool sleep;
        public bool electric;
        public bool dark;
        public Vector2 targetPosition;

        // TODO : Ajuster vitesse
        public Vector2 velocity;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("TriggerEnter_monster");

            if (collision.gameObject.CompareTag("Tank"))
            {
                Debug.Log("Tank collision");

                life -= collision.gameObject.GetComponent<RoadTower>().power;
                collision.gameObject.GetComponent<RoadTower>().takeDamage(power);
            }
            else if (collision.gameObject.CompareTag("WhiteHouse"))
            {
                Debug.Log("WhiteHouse collision");

                collision.gameObject.GetComponent<MaisonBlanche>().takeDamage(power);
            }
        }

        // Start is called before the first frame update
        void Start()
        { 
           
            MapManager.mapManager.setList();
        }

        protected void goToTarget(Vector2 target)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
    
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
                Destroy(this);
                Debug.Log("Mort en tab");
                GameManager.gameManager.AddMoney(amountToAdd);
                
            }
        }

        public int GetPower() { return power; }

        public int GetLife() { return life; }

        public int DamageLife(int attack)
        {

            life -= attack;
            Debug.Log("Damaged");
            return life;

        }
    }

}