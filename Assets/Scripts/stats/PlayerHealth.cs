using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int MaxHealth;
    public int Health;
    public int PlayerDamage;
    public bool IsHolding;
    public StatBoost Statboost;

    void Start()
    {
        Health = MaxHealth;
    }

    void Update()
    {
    }

public void TakeDamage(int damage)
{
    Health -= damage;
    if( Health <= 0)
    {
        Destroy(gameObject);
    }
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
    if (Input.GetKeyDown("e") && IsHolding == false && collision.gameObject.tag == "PlusAttack")
        {
            PlayerDamage += Statboost.AttackBoost;
            IsHolding = true;
        }
    }

}
