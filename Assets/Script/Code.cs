using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Code : MonoBehaviour
{
    public GameObject start, scene_01, scene_02, scene_03, scene_04, scene_05, scene_06, scene_07, scene_08, scene_09, scene_10, scene_11, scene_12, scene_13, scene_14, scene_15, scene_16, scene_17, scene_18, scene_19, scene_20, scene_21, scene_22, scene_23, scene_24, scene_25, scene_26, scene_27, scene_28, scene_29, scene_30, scene_31, scene_32, scene_33, scene_34, scene_35, scene_36, scene_37, scene_38, scene_39, scene_40, scene_41, scene_42, scene_43, scene_44, scene_45, scene_46, scene_47, scene_48;
    public GameObject endingScene_01, endingScene_11, endingScene_02, endingScene_03;
    public GameObject stats;
    public TextMeshProUGUI affectionValue, sanityValue;
    public int affectionPoints, sanityPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        start.SetActive(true);
        stats.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        affectionValue.text = affectionPoints.ToString();
        sanityValue.text = sanityPoints.ToString();

        if(affectionPoints >= 15)
        { 
            scene_24.SetActive(true);
        }

        if(sanityPoints >= 15)
        {
            scene_29.SetActive(true);
        }
    }

    public void StartButton()
    {
        start.SetActive(false);
        scene_01.SetActive(true);
        stats.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void StayStillButton()
    {
        endingScene_01.SetActive(true);
        scene_01.SetActive(false);
    }

    public void LookAroundButton()
    {
        scene_01.SetActive(false);
        scene_02.SetActive(true);
    }

    public void StopWalkingButton()
    {
        endingScene_01.SetActive(true);
        scene_03.SetActive(false);
    }

    public void KeepWalkingButton()
    {
        scene_03.SetActive(false);
        scene_04.SetActive(true);
    }

    public void DontOpenDoorButton()
    {
        endingScene_11.SetActive(true);
        scene_05.SetActive(false);
    }

    public void OpenDoorButton()
    {
        scene_05.SetActive(false);
        scene_06.SetActive(true);
    }

    public void HatchetButton()
    {
        scene_08.SetActive(false);
        scene_10.SetActive(true);
        sanityPoints += 5;
    }

    public void HeartShapedButton()
    {
        scene_08.SetActive(false);
        scene_09.SetActive(true);
        affectionPoints += 5;
    }

    public void BubblyGirlButton()
    {
        scene_14.SetActive(false);
        scene_15.SetActive(true);
        affectionPoints += 5;
    }

    public void FamiliarGirlButton()
    {
        scene_14.SetActive(false);
        scene_16.SetActive(true);    
        sanityPoints += 5;
    }

    public void LouButton()
    {
        scene_19.SetActive(false);
        scene_20.SetActive(true);
        affectionPoints += 5;
    }

    public void MinaButton()
    {
        scene_19.SetActive(false);
        scene_21.SetActive(true);
        sanityPoints += 5;
    }

    public void Scene02NextButton()
    {
        scene_02.SetActive(false);
        scene_03.SetActive(true);
    }

    public void Scene04NextButton()
    {
        scene_04.SetActive(false);
        scene_05.SetActive(true);
    }

    public void Scene06NextButton()
    {
        scene_06.SetActive(false);
        scene_07.SetActive(true);
    }

    public void Scene07NextButton()
    {
        scene_07.SetActive(false);
        scene_08.SetActive(true);
    }

    public void Scene09NextButton()
    {
        scene_09.SetActive(false);
        scene_11.SetActive(true);
    }

    public void Scene10NextButton()
    {
        scene_10.SetActive(false);
        scene_11.SetActive(true);
    }

    public void Scene11NextButton()
    {
        scene_11.SetActive(false);
        scene_12.SetActive(true);
    }

    public void Scene12NextButton()
    {
        scene_12.SetActive(false);
        scene_13.SetActive(true);
    }

    public void Scene13NextButton()
    {
        scene_13.SetActive(false);
        scene_14.SetActive(true);
    }

    public void Scene15NextButton()
    {
        scene_15.SetActive(false);
        scene_17.SetActive(true);
    }

    public void Scene16NextButton()
    {
        scene_16.SetActive(false);
        scene_17.SetActive(true);
    }

    public void Scene17NextButton()
    {
        scene_17.SetActive(false);
        scene_18.SetActive(true);
    }

    public void Scene18NextButton()
    {
        scene_18.SetActive(false);
        scene_19.SetActive(true);
    }

    public void Scene24NextButton()
    {
        scene_24.SetActive(false);
        scene_25.SetActive(true);
    }

    public void Scene25NextButton()
    {
        scene_25.SetActive(false);
        scene_26.SetActive(true);
    }

    public void Scene26NextButton()
    {
        scene_26.SetActive(false);
        scene_27.SetActive(true);
    }

    public void Scene27NextButton()
    {
        scene_27.SetActive(false);
        scene_28.SetActive(true);
    }

    public void Scene28NextButton()
    {
        scene_28.SetActive(false);
        endingScene_02.SetActive(true);
    }

    public void scene29NextButton()
    {
        scene_29.SetActive(false);
        scene_30.SetActive(true);
    }

    public void scene30NextButton()
    {
        scene_30.SetActive(false);
        scene_31.SetActive(true);
    }

    public void scene31NextButton()
    {
        scene_31.SetActive(false);
        scene_32.SetActive(true);
    }

    public void scene32NextButton()
    {
        scene_32.SetActive(false);
        scene_33.SetActive(true);
    }

    public void scene33NextButton()
    {
        scene_33.SetActive(false);
        scene_34.SetActive(true);
    }

    public void scene34NextButton()
    {
        scene_34.SetActive(false);
        scene_35.SetActive(true);
    }

    public void scene35NextButton()
    {
        scene_35.SetActive(false);
        scene_36.SetActive(true);
    }

    public void scene36NextButton()
    {
        scene_36.SetActive(false);
        scene_37.SetActive(true);
    }

    public void scene37NextButton()
    {
        scene_37.SetActive(false);
        scene_38.SetActive(true);
    }

    public void scene38NextButton()
    {
        scene_38.SetActive(false);
        scene_39.SetActive(true);
    }

    public void scene39NextButton()
    {
        scene_39.SetActive(false);
        scene_40.SetActive(true);
    }

    public void scene40NextButton()
    {
        scene_40.SetActive(false);
        scene_41.SetActive(true);
    }

    public void scene41NextButton()
    {
        scene_41.SetActive(false);
        scene_42.SetActive(true);
    }

    public void scene42NextButton()
    {
        scene_42.SetActive(false);
        scene_43.SetActive(true);
    }

    public void scene43NextButton()
    {
        scene_43.SetActive(false);
        scene_44.SetActive(true);
    }

    public void scene44NextButton()
    {
        scene_44.SetActive(false);
        scene_45.SetActive(true);
    }

    public void scene45NextButton()
    {
        scene_45.SetActive(false);
        scene_46.SetActive(true);
    }

    public void scene46NextButton()
    {
        scene_46.SetActive(false);
        scene_47.SetActive(true);
    }

    public void scene47NextButton()
    {
        scene_47.SetActive(false);
        scene_48.SetActive(true);
    }

    public void scene48NextButton()
    {
        scene_48.SetActive(false);
        endingScene_03.SetActive(true);
    }
}
