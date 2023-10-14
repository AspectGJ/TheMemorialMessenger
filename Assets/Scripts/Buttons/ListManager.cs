using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq.Expressions;

public class ListManager : MonoBehaviour
{
    public TextMeshProUGUI item1;
    public TextMeshProUGUI item2;
    public TextMeshProUGUI item3;
    public TextMeshProUGUI item4;

    public TextMeshProUGUI letterText;

    int itemNum;


    // Start is called before the first frame update
    void Start()
    {
        //get this object's Button component
        itemNum = GetComponent<Buttons>().whichItem;
    }

    // Update is called once per frame
    void Update()
    {
        switch (itemNum)
        {
            case 1:
                item1.text = "letter 1";
                letterText.text = "A";
                break;
            case 2:
                item2.text = "letter 2";
                letterText.text = "B";
                break;
            case 3:
                item3.text = "letter 3";
                letterText.text = "C";
                break;
            case 4:
                item4.text = "letter 4";
                letterText.text = "D";
                break;
        }
    }
}
