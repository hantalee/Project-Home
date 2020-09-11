using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void Del_CheckDate(int date);
    public event Del_CheckDate Del_checkDate;

    public int limitMinuteTime = 0;
    public int currentDate = 0;

    private static EventManager instance;
    public static EventManager Instance
    {
        get
        {
            if (instance != null)
                return instance;

            return null;
        }
    }
    private void Awake()
    {
        if (instance != null)
            Destroy(instance);

        instance = this;
    }

    private void Start()
    {
        StartCoroutine(DayCycle());
    }

    IEnumerator DayCycle()
    {
        while (true)
        {
            StartDay();

            float time = limitMinuteTime * 60.0f;
            yield return new WaitForSecondsRealtime(time);
        }
    }

    void StartDay()
    {
        IncreaseDate();
    }

    void EndDay(int test)
    {

    }

    void IncreaseDate()
    {
        currentDate += 1;
        Del_checkDate(currentDate);
    }
}
