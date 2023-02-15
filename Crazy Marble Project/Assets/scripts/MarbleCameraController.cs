using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCameraController : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float zDistance;

    [SerializeField]
    private float yDistance;

    // Update is called once per frame
    void Update()
    {
        Vector3 p = _target.position;
        p.z = p.z -= zDistance;
        p.y = p.y += yDistance;
        transform.position = p;
    }
}
