using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public PlayerStats playerStats;
    public int EnemyHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerStats.TakeDamage(damage);
        }

        if(collision.gameObject.tag == "Attack")
        {
            DealDamage();
        }

    }
    private void DealDamage()
    {
        EnemyHealth -= playerStats.PlayerDamage;
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }



}
