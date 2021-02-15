
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private Transform target;

    [SerializeField]
    private float distance;

    [SerializeField]
    private float targetHeight;

    private float x = 0, y =0;
    #endregion



    private void LateUpdate()
    {
        if (!target)
            return;

        y = target.eulerAngles.y;

        // Rotate Camera;
        Quaternion rotation = Quaternion.Euler(x, y, 0);
        transform.rotation = rotation;

        // Position Camera:
        var position = target.position - (rotation * Vector3.forward * distance + new Vector3(0, -targetHeight, 0));
        transform.position = position;
    }


} // CameraFollow class
