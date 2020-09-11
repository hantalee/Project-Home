using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public EventManager eventMgr;

    public Text timeText;
    private float time;

    //싱글톤
    private static GameManager instance;
    public static GameManager Instance 
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
    }

    private void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString();
    }


}
