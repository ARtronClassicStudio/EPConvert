using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Linq;

public class EPConvert : MonoBehaviour
{
    [MenuItem("CONTEXT/PolygonCollider2D/Convert to Edge Collider 2D and remove current component")]
    static internal void ToEdgeColliderAndRemove(MenuCommand command)
    {
        var poly = command.context as PolygonCollider2D;

        if (poly)
        {
            List<Vector2> points = poly.points.ToList();
            points.Add(poly.points[0]);
            poly.gameObject.AddComponent<EdgeCollider2D>().points = points.ToArray();
        }
        DestroyImmediate(poly);
    }
    [MenuItem("CONTEXT/PolygonCollider2D/Convert to Edge Collider 2D and no remove current component")]
    static internal void ToEdgeColliderAndNoRemove(MenuCommand command)
    {
        var poly = command.context as PolygonCollider2D;

        if (poly)
        {
            List<Vector2> points = poly.points.ToList();
            points.Add(poly.points[0]);
            poly.gameObject.AddComponent<EdgeCollider2D>().points = points.ToArray();
        }
    }
    [MenuItem("CONTEXT/EdgeCollider2D/Convert to Polygon Collider 2D and remove current component")]
    static internal void ToPolygonColliderAndRemove(MenuCommand command)
    {
        var poly = command.context as EdgeCollider2D;

        if (poly)
        {
            List<Vector2> points = poly.points.ToList();
            points.Add(poly.points[0]);
            poly.gameObject.AddComponent<PolygonCollider2D>().points = points.ToArray();
        }
        DestroyImmediate(poly);
    }
    [MenuItem("CONTEXT/EdgeCollider2D/Convert to Polygon Collider 2D and no remove current component")]
    static internal void ToPolygonColliderAndNoRemove(MenuCommand command)
    {
        var poly = command.context as EdgeCollider2D;

        if (poly)
        {
            List<Vector2> points = poly.points.ToList();
            points.Add(poly.points[0]);
            poly.gameObject.AddComponent<PolygonCollider2D>().points = points.ToArray();
        }
    }
}