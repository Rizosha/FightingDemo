using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MiddlePoint : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    Vector3 middlePoint;

    private void Update()
    {
        middlePoint = (p1.transform.position + p2.transform.position) / 2f;
        transform.position = middlePoint;
        transform.LookAt(new Vector3(p2.transform.position.x, transform.position.y, p2.transform.position.z));
    }
}
