
using System.Collections;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Vector3 topViewOffset;
    private bool isTopView = false;

    private void Start()
    {
        // Start the coroutine to change the camera position after 2 seconds
        StartCoroutine(ChangeToTopViewAfterDelay(2f));
    }

    private void Update()
    {
        if (!isTopView)
        {
            // Regular follow position
            transform.position = target.position + offset;
            // Update rotation to look at the target
            transform.rotation = Quaternion.LookRotation(target.position - transform.position);
        }
        else
        {
            // Follow position in top view
            transform.position = target.position + topViewOffset;
            // Set the camera to look directly downwards
            transform.rotation = Quaternion.Euler(90, 0, 0); // 90 degrees on the X axis to look straight down
        }
    }

    private IEnumerator ChangeToTopViewAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);
        // Switch to top view
        isTopView = true;
    }
}