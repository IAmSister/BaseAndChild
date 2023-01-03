using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;
using System;
public class Obj_ZombieUser : Obj_Mono
{
    public  bool Init(Obj_Init_Data initData) //override
    {
        //服务器发过来的信息    
        
        return false;
    }

    void FixedUpdate()
    {
       
        //多次冒血的
     
        //技能结束检测
       
    }

    void OnBecameVisible()
    {
        //设置是否在视口内标记位，为其他系统优化判断标识
      
        //显示名字版
        
        //显示模型
       
        //如果已经死亡，则切换到死亡状态
      
    }

    void OnBecameInvisible()
    {
        //设置是否在视口内标记位，为其他系统优化判断标识

        //隐藏名字版

        //隐藏模型
       
    }
}
