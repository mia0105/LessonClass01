using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaiCaiUI : MonoBehaviour
{
    public Text text;
    public ExcelData_SO excelData;
    // Start is called before the first frame update
    void Start()
    {
        if (excelData != null)
        {
            text.text = "名称：" + excelData.Sheet1[0].name + " "
            + "类别：" + excelData.Sheet1[0].type + " "
            + "攻击力：" + excelData.Sheet1[0].attack + " "
            + "防御力：" + excelData.Sheet1[0].defense + " "
            + "生命：" + excelData.Sheet1[0].HP + " ";
        }
    }
}