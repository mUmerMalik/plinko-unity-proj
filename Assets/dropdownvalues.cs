using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdownvalues : MonoBehaviour
{

    public GameObject[] DropObjects;
    public   Dropdown m_Dropdown;
    
        public void ChangeLocationDropDown()
    {
        Debug.Log("DROP DOWN CHANGED");
      
        // m_Dropdown = GetComponent();
        Debug.Log(m_Dropdown.options[m_Dropdown.value].text);

if(m_Dropdown.options[m_Dropdown.value].text=="Low")
{
    DropObjects[0].SetActive(true);
    DropObjects[1].SetActive(false);
    DropObjects[2].SetActive(false);
}
else if(m_Dropdown.options[m_Dropdown.value].text=="Medium")
{
   DropObjects[0].SetActive(false);
    DropObjects[1].SetActive(true);
    DropObjects[2].SetActive(false); 
}
else if(m_Dropdown.options[m_Dropdown.value].text=="High")
{
   DropObjects[0].SetActive(false);
    DropObjects[1].SetActive(false);
    DropObjects[2].SetActive(true);  
}

        //store in variable
       // valueText = m_Dropdown.options[m_Dropdown.value].text;
        //set textbox value
       // textBox.text = valueText;
    }
}
