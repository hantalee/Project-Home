using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequireDate : EventRequirements
{
    public RequireDate(int requireDate)
    {
        this.RequireDate = requireDate;
    }

    public override void Init()
    {
        base.Init();
        EventManager.Instance.Del_checkDate += CheckDate;
    }

    void CheckDate(int date)
    {
        if (this.RequireDate == date)
        {
            Satisfy = true;
            Evalueate();
        }
    }
}
