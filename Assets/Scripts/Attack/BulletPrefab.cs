using System.Collections;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float distance;


    private void Start()
    {
        StartCoroutine(nameof(DeleteTimer));
    }
    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.right);
    }

    IEnumerator DeleteTimer()
    {
        yield return new WaitForSeconds(distance);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
        Destroy(gameObject);
        }
    }
}
