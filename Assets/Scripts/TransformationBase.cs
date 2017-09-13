using UnityEngine;

public abstract class TransformationBase : MonoBehaviour
{

    public Vector3 Apply(Vector3 point)
    {
        return Matrix.MultiplyPoint(point);
    }

    public abstract Matrix4x4 Matrix { get; }
}
