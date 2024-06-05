using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += transform.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position -= transform.forward * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += transform.right * speed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position -= transform.right * speed * Time.fixedDeltaTime;
        }
    }
}
