using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    public int Health;

    void Start()
    {
        Health = MaxHealth;
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
