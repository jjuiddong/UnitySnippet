using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float sensitivity0 = 0.1f;
    public float sensitivity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject inGameCamera = GameObject.Find("Main Camera");

            Vector3 forward = Camera.main.transform.forward;
            forward.y = 0f;
            forward.Normalize();

            Vector3 right;
            right = Camera.main.transform.right;
            right.y = 0f;
            right.Normalize();

            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            if (x != 0f && y != 0f)
            {
                Vector3 mov = forward * -y * sensitivity0 + 
                    right * -x * sensitivity0;
                transform.position += mov;
            }
        }

        if (Input.GetMouseButton(1))
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            transform.RotateAround(Vector3.zero, -Vector3.up, x * sensitivity);
            transform.RotateAround(Vector3.zero, transform.right, y * sensitivity);
        }
    }

}
