using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int MaxHealth;
    public int Health;
    public int PlayerDamage;
    public StatBoost Statboost;

    void Start()
    {
        Health = MaxHealth;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "PlusAttack")
        {
            PlayerDamage += Statboost.AttackBoost;
        }
    }

public void TakeDamage(int damage)
{
    Health -= damage;
    if( Health <= 0)
    {
        Destroy(gameObject);
    }
}

}
