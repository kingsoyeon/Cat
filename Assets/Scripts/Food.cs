using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * 0.5f; // transform.position.y 같이 하나만 올리는건 쓸수없음 vector3를 이용해 y만 1*0.5씩 계속해서 더해서 올려줄수있음
        if (transform.position.y > 27.0f)
        {
            Destroy(gameObject);
        }
    }
}
