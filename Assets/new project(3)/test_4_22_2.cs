using UnityEngine;

public class test03_03 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        int counter = 5;
        counter = counter + 10;
        Debug.Log(counter);
        counter = counter + 35;
        Debug.Log(counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
