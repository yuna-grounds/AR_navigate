using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DrawPathfinding : MonoBehaviour
{
    public NavMeshAgent agent;
    public LineRenderer lineRenderer;
    public Transform target;
    private void Start()
    {
        agent.destination = target.position;
    }

    private void Update()
    {
        // NavMeshAgent 가 이동중이 아닌 경우 return
        if (!agent.hasPath) return;

        // 경로를 가져와서 라인 그리기
        var path = agent.path;
        var corners = path.corners;
        lineRenderer.positionCount = corners.Length;
        for (int i = 0; i < corners.Length; i++)
        {
            corners[i] += new Vector3(0, 3, 0);
            lineRenderer.SetPosition(i, corners[i]);
        }
    }
}
