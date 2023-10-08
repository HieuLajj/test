using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class YourScript : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public CinemachineTrackedDolly dollyTrack;
    private Quaternion startRotation;
    private Quaternion endRotation;
    public CinemachineSmoothPath smoothPath;
    private void Start()
    {
        dollyTrack = virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        startRotation = Quaternion.Euler(-25f, -90f, 0f);
        endRotation = Quaternion.Euler(15f, -90f, 0f);
        //StartCoroutine(ChangePathPositionOverTime(2f));
        // Vector3 newWaypoint = new Vector3(1f, 2f, 3f);
        // smoothPath.m_Waypoints[0] = newWaypoint;

        // Xóa waypoint
        // if (smoothPath.m_Waypoints.Count > 0)
        // {
        //     smoothPath.m_Waypoints.RemoveAt(0);
        // }
         // Add waypoint
        Vector3 newWaypoint = new Vector3(1f, 2f, 3f);
        CinemachineSmoothPath.Waypoint[] currentWaypoints = smoothPath.m_Waypoints;
        CinemachineSmoothPath.Waypoint[] newWaypoints = new CinemachineSmoothPath.Waypoint[currentWaypoints.Length + 1];
        currentWaypoints.CopyTo(newWaypoints, 0);
        newWaypoints[newWaypoints.Length - 1] = new CinemachineSmoothPath.Waypoint
        {
            position = newWaypoint,
            roll = 0f
        };
        smoothPath.m_Waypoints = newWaypoints;
        smoothPath.m_Waypoints = new CinemachineSmoothPath.Waypoint[0];
        // // Remove waypoint
        // if (smoothPath.m_Waypoints.Length > 0)
        // {
        //     CinemachineSmoothPath.Waypoint[] updatedWaypoints = new CinemachineSmoothPath.Waypoint[smoothPath.m_Waypoints.Length - 1];
        //     System.Array.Copy(smoothPath.m_Waypoints, 1, updatedWaypoints, 0, updatedWaypoints.Length);
        //     smoothPath.m_Waypoints = updatedWaypoints;
        // }
    }
    // private IEnumerator ChangePathPositionOverTime(float duration)
    // {
    //     float elapsedTime = 0f;
    //     float startValue = 0f;
    //     float endValue = 1f;

    //     while (elapsedTime < duration)
    //     {
    //         float t = elapsedTime / duration;
    //         dollyTrack.m_PathPosition = Mathf.Lerp(startValue, endValue, t);
    //         virtualCamera.transform.rotation = Quaternion.Lerp(startRotation, endRotation, t);
    //         elapsedTime += Time.deltaTime;
    //         yield return null;
    //     }

    //     // Đảm bảo giá trị cuối cùng là 1
    //     virtualCamera.transform.rotation = endRotation;
    //     dollyTrack.m_PathPosition = endValue;
    // }
}