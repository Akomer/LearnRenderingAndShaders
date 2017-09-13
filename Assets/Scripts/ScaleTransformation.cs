
using UnityEngine;

public class ScaleTransformation : TransformationBase
{
    public Vector3 scaleRate;


    #region implemented abstract members of TransformationBase

    public override Matrix4x4 Matrix
    {
        get
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetRow(0, new Vector4(scaleRate.x, 0f, 0f, 0f));
            matrix.SetRow(1, new Vector4(0f, scaleRate.y, 0f, 0f));
            matrix.SetRow(2, new Vector4(0f, 0f, scaleRate.z, 0f));
            matrix.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
            return matrix;
        }
    }

    #endregion
}
