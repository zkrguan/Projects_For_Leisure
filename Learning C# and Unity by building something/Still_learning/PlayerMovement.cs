using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      float h = Input.GetAxis("Horizontal");
      float v = Input.GetAxis("Vertical");
      
      Vector2 pos = transform.position;
      // never forgot the speed //
      // same things as the jump and crouch//
      pos.x += h*Time.deltaTime*speed;
      pos.y += v*Time.deltaTime*speed;
      transform.position = pos;

    }
}// class
