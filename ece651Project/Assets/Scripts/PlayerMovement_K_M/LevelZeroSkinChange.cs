using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelZeroSkinChange : MonoBehaviour
{
    [SerializeField] private AnimatorOverrideController levelfive;
    [SerializeField] private AnimatorOverrideController levelone;
    [SerializeField] private AnimatorOverrideController leveltwo;
    [SerializeField] private AnimatorOverrideController levelthree;
    [SerializeField] private AnimatorOverrideController levelfour;

    private AnimatorOverrideController[] controllerArray;

    void Start()
    {
        //controllerArray[0] = levelone;
        controllerArray = new AnimatorOverrideController[] { levelone, leveltwo, levelthree, levelfour, levelfive };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeCharSkin(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeCharSkin(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeCharSkin(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangeCharSkin(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ChangeCharSkin(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            ChangeCharSkin(0);
        }
    }

    private void ChangeCharSkin(int skinIndex)
    {
        if (skinIndex == 0)
        {
            GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animation/Hamburger") as RuntimeAnimatorController;
        }
        else
        {
            GetComponent<Animator>().runtimeAnimatorController = controllerArray[skinIndex-1] as RuntimeAnimatorController;
        }
    }
}
