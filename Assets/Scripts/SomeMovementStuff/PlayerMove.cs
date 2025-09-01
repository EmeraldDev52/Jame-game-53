using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 movement;


    public float offset;

    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        movement = movement.normalized;

        Rotate();

    }


    private void Rotate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        rb.rotation = rotateZ;
    }
    void FixedUpdate()
    {

        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }
}
