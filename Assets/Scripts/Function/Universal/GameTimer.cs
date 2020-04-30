using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour
{

    [Tooltip("Timer measurement set in seconds")]
    [SerializeField] float fltLevelTimer = 10;

    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / fltLevelTimer;

        bool TimerFinished = (Time.timeSinceLevelLoad >= fltLevelTimer);
        if (TimerFinished)
        {
            Debug.Log("YOUR TIME IS UP FOOL");
        }
    }
}
