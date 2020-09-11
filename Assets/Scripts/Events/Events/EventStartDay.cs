using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStartDay : GameEvent
{
    public int requireDate;

    private void Start()
    {
        EventName = "Start new day";

        Requirements.Add(new RequireDate(requireDate));
        Requirements.ForEach(g => g.Init());
    }
}
