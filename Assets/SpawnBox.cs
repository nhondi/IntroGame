using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject prefab;
    public void SpawnBoxAction()
    {
        Instantiate(prefab);
    }
}
