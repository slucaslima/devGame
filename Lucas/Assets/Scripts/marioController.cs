using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marioController : MonoBehaviour
{
    public float speed;
    public float minLimit, maxLimit;

    void Awake()
    {
        speed = Random.Range(minLimit, maxLimit);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.y, transform.position.x - speed * 0.01f);
    }
}
