using UnityEngine;
using UnityEngine.InputSystem;

public class GamePlayer : MonoBehaviour
{
    Vector2 moveValue;
    public int speed;
    public void OnMove(InputValue value)
    {
        moveValue= value.Get<Vector2>();
        Debug.Log("move:" + moveValue);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(moveValue.x*Time.deltaTime*speed,0,0);
        this.transform.Translate(0,moveValue.y*Time.deltaTime*speed,0);
    }
}
