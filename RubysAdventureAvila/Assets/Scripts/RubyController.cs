using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creating the two variables that use the pre built axes
        float hortizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //create the movement vector
        Vector2 position = transform.position;

        //changing the x and y position
        position.x = position.x + 3.0f * hortizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        //set the updated position
        transform.position = position;
        
    }
}
