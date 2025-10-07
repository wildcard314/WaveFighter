using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //example of calling gameManager
        Debug.Log(GameManager.instance.getScore());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
