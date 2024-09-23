using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int mult;
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 10f) * mult * Time.deltaTime);
    }
}
