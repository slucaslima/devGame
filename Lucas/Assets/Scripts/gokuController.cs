using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gokuController : MonoBehaviour
{
    public float positionY;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {

        //positionY = transform.position;
        speed = 5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        positionY = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(0, positionY * speed * Time.deltaTime, 0);
    }
}
