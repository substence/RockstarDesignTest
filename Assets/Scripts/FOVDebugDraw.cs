using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVDebugDraw : MonoBehaviour
{
    public Color c1 = Color.yellow;
    public Color c2 = Color.red;
    public int lengthOfLineRenderer = 20;
    public LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.widthMultiplier = 0.2f;
        lineRenderer.positionCount = 4;
        lineRenderer.useWorldSpace = true;
    }

       // Update is called once per frame
    void Update ()
    {
        int length = 1;
        int fov = 14;
        Vector3 start = this.gameObject.transform.position;
        Vector3 target = new Vector3(start.x, start.y + 5, start.z);


        float angleInDeg = Vector3.Angle(start, target);
        float leftAngle = Mathf.Deg2Rad * angleInDeg - fov;
        Vector2 leftProjection = new Vector2(Mathf.Cos(leftAngle) * length, Mathf.Sin(leftAngle) * length);
        float rightAngle = Mathf.Deg2Rad * angleInDeg + fov;
        Vector2 rightProjection = new Vector2(Mathf.Cos(rightAngle) * length, Mathf.Sin(rightAngle) * length);
        lineRenderer.SetPosition(0, start);
        lineRenderer.SetPosition(1, leftProjection);
        lineRenderer.SetPosition(2, rightProjection);
        lineRenderer.SetPosition(3, start);
    }
}
