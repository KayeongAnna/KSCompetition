using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold = 45;
    public Transform origin = null;
    public GameObject streamPrefab = null;

    private bool isPouring = false;
    private Stream currentSteam = null;

    private void Update()
    {
        bool pourCheck = CalculatePourAngle() < pourThreshold;

        if(isPouring != pourCheck)
        {
            isPouring = pourCheck;

            if (isPouring)
            {
                StartPour();

            }
            else
            {
                EndPour();
            }
        }
    }

    private void StartPour()
    {
        print("Start");
    }

    private void EndPour()
    {
        print("End");
    }

    private float CalculatePourAngle()
    {
        return transform.forward.y = Mathf.Rad2Deg;
    }

    private Stream CreateStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin.position, Quaternion.identity, transform);
        return streamObject.GetComponent<Stream>();
    }

}
