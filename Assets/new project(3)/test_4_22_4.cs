using JetBrains.Annotations;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class test03_05 : MonoBehaviour
    
{
    public int value;
    int counter = 5;
    float time = 4f;
    string namePlayer = "PlayerName";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Debug.Log("Start counter:" + counter);
        Debug.Log("Start time:" + time);
        Debug.Log("Start nameplayer:" + namePlayer);
        Debug.Log(value);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update counter:" + counter);
        Debug.Log("Update time:" + time);
        Debug.Log("Update nameplaye:r" + namePlayer);
        Debug.Log(value);
    }
}
