using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro;
    public string storyText, Level1Text, Level2Text, Level3Text, Level4Text;
    public GameObject MenuChoices, Level_1_Choices, Level_2_Choices, Level_3_Choices, Level_4_Choices;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
    }
    public void PlayButton()
    {
        storyText = Level1Text;
        MenuChoices.SetActive(false);
        Level_1_Choices.SetActive(true);
    }
    public void FirstDoor()
    {
        storyText = Level2Text;
        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(true);
    }
    public void SecondDoor()
    {
        Level_1_Choices.SetActive(false);
    }
    public void Google()
    {
        storyText = Level3Text;
        Level_2_Choices.SetActive(false);
        Level_3_Choices.SetActive(true);
    }
    public void CCTV()
    {
        Level_2_Choices.SetActive(false);
    }
    public void Escape()
    {
        storyText = Level4Text;
        Level_3_Choices.SetActive(false);
        Level_4_Choices.SetActive(true);
    }
    public void Stay()
    {
        Level_3_Choices.SetActive(false);
    }
}

