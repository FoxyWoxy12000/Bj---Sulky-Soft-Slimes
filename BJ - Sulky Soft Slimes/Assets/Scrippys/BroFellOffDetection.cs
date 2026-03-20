using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroFellOffDetection : MonoBehaviour
{
    public YouLose losescrip;

    void OnTriggerExit(Collider thingy)
    {
        losescrip.YouLoser();
    }
}
