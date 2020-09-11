using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRequirements
{
    public GameEvent Event { get; set; }
    public Item[] RequireItems { get; set; }
    public int RequireDate { get; set; }
    //요구조건 - 플레이어 상태
    public bool Satisfy { get; set; }

    public virtual void Init()
    {

    }

    public void Evalueate()
    {
        if(Satisfy)
            EventExecution();
    }

    public void EventExecution()
    {
        Debug.Log("EventExecution");
    }
}
