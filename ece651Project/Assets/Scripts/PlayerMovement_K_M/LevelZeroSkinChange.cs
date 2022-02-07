using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelZeroSkinChange : MonoBehaviour
{
    [SerializeField] private AnimatorOverrideController levelfive;
    [SerializeField] private AnimatorOverrideController levelone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeCharSkin(1);
        }
    }

    private void ChangeCharSkin(int skinIndex)
    {
        //do a case switch for all skins?
        GetComponent<Animator>().runtimeAnimatorController = levelone as RuntimeAnimatorController;
    }
}
