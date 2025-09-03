using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform[] PatrolPoints;
    public float MoveSpeed;
    public int PatrolDestination;

    public Transform PlayerTransform;
    public bool IsChasing;
    public float ChaseDistance;

    // Update is called once per frame
    void Update()
    {


        if (IsChasing) 
        {
            if (transform.position.x > PlayerTransform.position.x)
            {
                transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
            }
            else if (transform.position.x < PlayerTransform.position.x)
            {
                transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
            }
            if (transform.position.y > PlayerTransform.position.y)
            {
                transform.position += Vector3.down * MoveSpeed * Time.deltaTime;
            }
            else if (transform.position.y < PlayerTransform.position.y)
            {
                transform.position += Vector3.up * MoveSpeed * Time.deltaTime;
            }
        }
        else 
        {
            if (Vector2.Distance(transform.position, PlayerTransform.position) < ChaseDistance)
            {
                IsChasing = true;
            }



            if (PatrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, PatrolPoints[0].position, MoveSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, PatrolPoints[0].position) < 0.2f) 
            {
                transform.localScale = new Vector3(1, 1, 1);
                PatrolDestination = 1;
            }
        }
             if (PatrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, PatrolPoints[1].position, MoveSpeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, PatrolPoints[1].position) < 0.2f) 
            {
                transform.localScale = new Vector3(1, -1, 1);
                PatrolDestination = 0;
            }
        }



        }
    }
}
