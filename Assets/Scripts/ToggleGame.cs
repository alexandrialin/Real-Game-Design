using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToggleGame : MonoBehaviour
{
    public Toggle Toggle1;
    public Toggle Toggle2;
    public Toggle Toggle3;
    public Toggle Toggle4;
    public Toggle Toggle5;
    public Toggle Toggle6;
    public Toggle Toggle7;
    public Toggle Toggle8;
    public Toggle Toggle9;
    public Toggle Toggle10;
    public Toggle Toggle11;
    public Toggle Toggle12;
    public Toggle Toggle13;
    public Toggle Toggle14;
    public Toggle Toggle15;
    public Toggle Toggle16;
    public GameObject wall;
    void Start()
    {
        print("hi");

    }
    
    public void WhenToggled1()
    {
            LightSwitch(Toggle2);
            LightSwitch(Toggle5);
            
        }
   
    public void WhenToggled2()
    {
        LightSwitch(Toggle1);
        LightSwitch(Toggle3);
 
 
        LightSwitch(Toggle6);
    }
    
    public void WhenToggled3()
    {
        LightSwitch(Toggle2);
        LightSwitch(Toggle4);

        LightSwitch(Toggle7);

    }
    public void WhenToggled4()
    {
        LightSwitch(Toggle3);

        LightSwitch(Toggle8);

    }
    public void WhenToggled5()
    {
        LightSwitch(Toggle1);

        LightSwitch(Toggle6);
        LightSwitch(Toggle9);

    }
    public void WhenToggled6()
    {
  
        LightSwitch(Toggle2);

        LightSwitch(Toggle5);
        LightSwitch(Toggle7);

        LightSwitch(Toggle10);

       
    }
    public void WhenToggled7()
    {

        LightSwitch(Toggle3);
        LightSwitch(Toggle6);
        LightSwitch(Toggle8);

        LightSwitch(Toggle11);
    }
    public void WhenToggled8()
    {

        LightSwitch(Toggle4);
        LightSwitch(Toggle7);

        LightSwitch(Toggle12);
    }
    public void WhenToggled16()
    {
        LightSwitch(Toggle15);
        LightSwitch(Toggle12);

    }
    public void WhenToggled15()
    {
        LightSwitch(Toggle16);
        LightSwitch(Toggle14);

        LightSwitch(Toggle11);

    }
    public void WhenToggled14()
    {
        LightSwitch(Toggle13);
        LightSwitch(Toggle15);

        LightSwitch(Toggle10);

    }
    public void WhenToggled13()
    {
        LightSwitch(Toggle9);

        LightSwitch(Toggle14);

    }
    public void WhenToggled12()
    {

        LightSwitch(Toggle8);
        LightSwitch(Toggle11);

        LightSwitch(Toggle16);
    }
    public void WhenToggled11()
    {

        LightSwitch(Toggle7);

        LightSwitch(Toggle10);
        LightSwitch(Toggle12);

        LightSwitch(Toggle15);


    }
    public void WhenToggled10()
    {
 
        LightSwitch(Toggle6);

        LightSwitch(Toggle9);
        LightSwitch(Toggle11);

        LightSwitch(Toggle14);

    }
    public void WhenToggled9()
    {
        LightSwitch(Toggle5);

        LightSwitch(Toggle10);
        LightSwitch(Toggle13);

    }
    

    public void LightSwitch(Toggle button)
    {
        if (button.isOn == true)
        {
            button.isOn = false;
        }
        else if (button.isOn == false)
        {
            button.isOn = true;
        }
        if(Toggle1.isOn && Toggle2.isOn && Toggle3.isOn && Toggle4.isOn && Toggle5.isOn && Toggle6.isOn && Toggle7.isOn && Toggle8.isOn && Toggle9.isOn && Toggle10.isOn && Toggle11.isOn && Toggle12.isOn && Toggle13.isOn && Toggle14.isOn && Toggle15.isOn && Toggle16.isOn)
        {
            wall.SetActive(false);
        }

    }
    }
        
        
    


