using UnityEngine;

public class test03_06 : MonoBehaviour
{
    public int value;
    public int counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(value);
        Debug.Log(value + counter);
    }
}
