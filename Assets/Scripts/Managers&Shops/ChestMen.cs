using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestMen : MonoBehaviour
{



    public Text commonText;
    public Text nobleText;
    public Text kingText;
    public Text legendText;


    // Update is called once per frame
    void Update()
    {
        commonText.text = GameManager.commonChest.ToString();
        nobleText.text = GameManager.NobleChest.ToString();
        kingText.text = GameManager.KingChest.ToString();
        legendText.text = GameManager.LegendChest.ToString();
    }

 



}
