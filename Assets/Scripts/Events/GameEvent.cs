using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameEvent : MonoBehaviour
{
    public List<EventRequirements> Requirements { get; set; } = new List<EventRequirements>();
    public string EventName { get; set; }
    public Item ItemReward { get; set; }
    public bool IsSatisfy { get; set; }

    public void CheckRequirements()
    {
        IsSatisfy = Requirements.All(g => g.Satisfy);
    }

    public void GiveReward()
    {
        if (ItemReward != null)
        {
            //아이템 보상 주기
        }
    }
}
