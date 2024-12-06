using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConnect : MonoBehaviour
{
    public Transform objectA; // ù ��° ������Ʈ
    public Transform objectB; // �� ��° ������Ʈ
    private LineRenderer lineRenderer;

    void Start()
    {
        
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;

    }

    void Update()
    {
        if (objectA != null && objectB != null)
        {           
            lineRenderer.SetPosition(0, objectA.position);
          
            lineRenderer.SetPosition(1, objectB.position);
        }
    }
}
