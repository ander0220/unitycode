using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    public float Speed = 2.0f;
    public float MaxMovement = 2.0f;

    private float movementX;
    
    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += movementX * Speed * Time.deltaTime;

        if (pos.x > MaxMovement)
            pos.x = MaxMovement;
        else if (pos.x < -MaxMovement)
            pos.x = -MaxMovement;

        transform.position = pos;
    }
    public void OnMove(InputValue value)
    {
    	movementX = value.Get<Vector2>().x;
    }
}
