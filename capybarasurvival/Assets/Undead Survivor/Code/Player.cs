using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputvec;
    public float speed;

    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        inputvec.x = Input.GetAxis("Horizontal");
        inputvec.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    { 
        Vector2 nexVec = inputvec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nexVec);
    }
}
