using UnityEngine;

public class BroFellOff : MonoBehaviour
{
    public YouWIn WInSCRIO;
    public int AmmountOfEVILGuys;
    public int ammountOfEVILFallGuys = 0;
    public YouLose losescrip;
    public int AmmountOFGuys;
    public int AmmountOFFallGuys = 0;

    public int AmmountOFFallALLOWED = 1;
    private void Start()
    {
        AmmountOfEVILGuys = GameObject.FindGameObjectsWithTag("bad").Length;
        AmmountOFGuys = GameObject.FindGameObjectsWithTag("good").Length;
    }

    

    private void Update()
    {
        if (ammountOfEVILFallGuys == AmmountOfEVILGuys)
        {
            WInSCRIO.YouWEEEEN();
        }
        if (AmmountOFFallGuys == AmmountOFFallALLOWED)
        {
            losescrip.YouLoser();
        }
    }
}
