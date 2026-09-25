using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 10;
    public string gender = "male";
    void Start()
    {
        Debug.Log("Player started!");
        Debug.Log("Player level: " + level);
        Debug.Log("Player gender: "+ gender);
    }

    void Update()
    {
        
    }
}
