using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilBroFellOffDetector : MonoBehaviour
{
    public YouWIn WInSCRIO;
    public int AmmountOfEVILGuys;
    public int ammountOfEVILFallGuys = 0;
    private void Start()
    {
        AmmountOfEVILGuys = GameObject.FindGameObjectsWithTag("bad").Length;
    }

    void OnTriggerExit(Collider thingy)
    {
        if (thingy.gameObject.tag.ToString() == ("bad"))
        {
            ammountOfEVILFallGuys++;
        }
    }

    private void Update()
    {
        if (ammountOfEVILFallGuys == AmmountOfEVILGuys)
        {
            WInSCRIO.YouWEEEEN();
        }
    }
}
