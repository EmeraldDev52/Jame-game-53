using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 movement;
    [SerializeField] Sprite[] ChangeFacing;
    [SerializeField] Sprite CurrentSprite;


    public float offset;

    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = CurrentSprite;
        

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown("a"))
        {
            CurrentSprite = ChangeFacing[0];
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKeyDown("d"))
        {
                transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKeyDown("s"))
        {
            CurrentSprite = ChangeFacing[2];

        }
        else if (Input.GetKeyDown("w"))
        {
            CurrentSprite = ChangeFacing[1];

        }


        movement = movement.normalized;


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
