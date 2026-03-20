using UnityEngine;

public class FellOffDetection : MonoBehaviour
{
    private BroFellOff brofelloffscript;
    void Start()
    {
        brofelloffscript = GameObject.Find("GameManager").GetComponent<BroFellOff>();
    }

    void OnTriggerExit(Collider thingy)
    {

        if (thingy.gameObject.tag.ToString() == ("good"))
        {
            brofelloffscript.AmmountOFFallGuys++;
        }
        if (thingy.gameObject.tag.ToString() == ("bad"))
        {
            brofelloffscript.ammountOfEVILFallGuys++;
        }
    }
}
