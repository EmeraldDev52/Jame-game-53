using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform[] PatrolPoints;
    public float MoveSpeed;
    public int PatrolDestination;

    // Update is called once per frame
    void Update()
    {
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
