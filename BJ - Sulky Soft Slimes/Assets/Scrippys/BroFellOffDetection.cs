using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroFellOffDetection : MonoBehaviour
{
    public YouLose losescrip;
    public int AmmountOFGuys;
    public int AmmountOFFallGuys = 0;

    public void Start()
    {
        AmmountOFGuys = GameObject.FindGameObjectsWithTag("good").Length;
    }

    void OnTriggerExit(Collider thingy)
    {
        if (thingy.gameObject.tag.ToString() == ("good"))
        {
            AmmountOFFallGuys++;
        }
    }
    public void Update()
    {
        if (AmmountOFFallGuys == AmmountOFGuys)
        {
            losescrip.YouLoser();
        }
    }
}
