using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}
