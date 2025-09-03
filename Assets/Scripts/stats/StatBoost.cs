using UnityEngine;

public class StatBoost : MonoBehaviour
{
    public int HealthBoost;
    public int AttackBoost;

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

