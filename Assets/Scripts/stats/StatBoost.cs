using UnityEngine;

public class StatBoost : MonoBehaviour
{
    public int HealthBoost;
    public int AttackBoost;
    public PlayerStats playerStats;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && playerStats.IsHolding)
        {
            Destroy(gameObject);
        }
    }
}

