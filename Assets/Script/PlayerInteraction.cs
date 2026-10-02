using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
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
        Debug.Log("Hit: "+ collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        if(collision.CompareTag("Coin"))
        Debug.Log("You recieved a coin!");
    }
}
