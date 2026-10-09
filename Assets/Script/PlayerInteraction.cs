using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // [SerializeField]
    // private int attackDamage = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
        Debug.Log("Hit: "+ collision.gameObject.name);
        }
        // else if(collision.gameObject.CompareTag("Enemy"))
        // {EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        // if(enemyHealth != null)
        //     {
        //         enemyHealth.TakeDamage(attackDamage);
        //     }
        // }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        if(collision.CompareTag("Coin"))
        Debug.Log("You recieved a coin!");
    }
}
