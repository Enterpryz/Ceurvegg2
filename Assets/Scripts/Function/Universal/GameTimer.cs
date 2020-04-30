using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{

    [Tooltip("Timer measurement set in seconds")]
    [SerializeField] float fltLevelTime = 10;

    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / fltLevelTime;

        bool TimerFinished = (Time.timeSinceLevelLoad >= fltLevelTime);
        if (TimerFinished)
        {
            Debug.Log("YOUR TIME IS UP FOOL");
        }
    }
}
