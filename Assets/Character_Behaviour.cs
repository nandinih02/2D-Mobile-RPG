using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Behaviour : MonoBehaviour
{
    private Vector2 follow;
    public float speed;
    
    void Start()
    {
        follow = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if(Input.GetMouseButtonDown(0))
        {
            follow = new Vector2(mousePos.x, mousePos.y);
        }
        transform.position = Vector2.MoveTowards(transform.position,follow, Time.deltaTime * speed);
    }
}
