using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class TouchBehavior : MonoBehaviour 
{
#if UNITY_ANDROID || UNITY_IOS

    float startTime;
    bool longTap;

    void Start()
    {
        
    }

    void Update()
    {
        check();
    }


    void check()
    {

        Touch[] touch = Input.touches;
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch t = touch[i];
            if (t.deltaTime > 0.3f) // if long touch 
            {
                // do stuff. 
                Application.OpenURL("http://unity3d.com/");
            }
        }
    }

#endif
}