using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public KeyCode spinKey = KeyCode.Space;
    public Vector3 spinAxis = Vector3.up;
    public float spinSpeed = 180f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(spinKey))
        {
            transform.Rotate(spinAxis * spinSpeed * Time.deltaTime, Space.Self);
        }
    }
}