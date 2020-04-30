using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int intLives = 5;
    [SerializeField] int intdamage = 1;
    Text livesText;

    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = intLives.ToString();
    }

    public void TakeLife()
    {
        intLives -= intdamage;
        UpdateDisplay();

        if (intLives <= 0)
        {
            FindObjectOfType<LevelLoad>().LoadYouLose();
        }
    }



}
