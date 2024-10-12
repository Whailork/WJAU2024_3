//using System.Linq;
using UnityEngine;

namespace Monster
{
    public class Godzilla : Monster
    {

        //public Godzilla() { life = 100; power = 20; sleep = false; electric = false; }

        // Variables
        public int nextPoint;
        public Collider2D Collider2D;
        public Rigidbody2D rb;

        void Awake()
        {
            Collider2D = GetComponent<Collider2D>();
            rb = GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Dynamic;

            Collider2D.enabled = true;

            rb.isKinematic = false;
        }

        // Start is called before the first frame update
        void Start()
        {

            electric = false;

            nextPoint = 0;
        }

        private void FixedUpdate()
        {
            if (targetPosition == Vector2.zero)
            {
                targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
            }

            if (nextPoint < MapManager.mapManager.pointsRepere.Count)
            {
                nextPoint = updateTargetPoint(nextPoint);
                goToTarget(targetPosition);
            }

        }

        void Update()
        {

        }


        public void IfdarkMode(bool dark)
        {
            if (dark == true)
            {
                if (dark == true)
                {
                    sleep = true;
                }
            }
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Collision with Monster");

            if (collision.gameObject.CompareTag("Tank"))
            {

                Debug.Log("Collision with Tank");
            }
        }
    }
}
