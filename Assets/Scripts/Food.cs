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
        transform.position += Vector3.up * 0.5f; // transform.position.y ���� �ϳ��� �ø��°� �������� vector3�� �̿��� y�� 1*0.5�� ����ؼ� ���ؼ� �÷��ټ�����
        if (transform.position.y > 27.0f)
        {
            Destroy(gameObject);
        }
    }
}
