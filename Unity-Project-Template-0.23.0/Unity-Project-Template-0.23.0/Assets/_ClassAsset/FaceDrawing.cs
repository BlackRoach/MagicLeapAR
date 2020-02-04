using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using OpenCVForUnity;
using DlibFaceLandmarkDetectorExample;

public class FaceDrawing : MonoBehaviour {

    public FrameOptimizationExample_JM myTracker;
    public GameObject marker1;    
    public int index;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        int faceCount = myTracker.GetFaceCount();
            

        if (faceCount > 0)
        {
            marker1.transform.position = myTracker.GetPointPosition(index);
   
        }
    }

    /*
	 * total number : 68
	 * ([38]+[41])/2 : l eye
	 * ([43]+[46])/2 : R eye
	 * [30] : nose
	 * [48] : L mouth
	 * [54] : R mouth
	 * [62] : mouth top
	 * [66] : mouth bottom
	 * [0] : L ear
	 * [16] : R ear
	 */
}
