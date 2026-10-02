//using System.Numerics;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.GetAxisRaw("Horizontal");
       float vertical = Input.GetAxisRaw("Vertical");

       direction = new Vector2(horizontal,vertical);

       if(direction.sqrMagnitude > 1f)
        {
            direction.Normalize();
        }
    }

    void FixedUpdate()
    {
        Vector2 targetPosition = 
        rb.position + (moveSpeed * Time.fixedDeltaTime * direction);

        rb.MovePosition(targetPosition);
    }

   
}
    
