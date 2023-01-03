using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;

public class Obj_Client : Obj_Character
{
    public Obj_Client()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_CLIENT;
    }

    void Awake()
    {
        m_ObjTransform = transform;
    }

    void FixedUpdate()
    {
        UpdateTargetMove();
        //m_AnimLogic¶¯»­¸üÐÂ
        
    }

    public override void OnAnimationFinish(int animationID)
    {
        base.OnAnimationFinish(animationID);
        
          
       
    }
}
