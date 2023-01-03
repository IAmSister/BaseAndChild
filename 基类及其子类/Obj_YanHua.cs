using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;
using System;


public class Obj_YanHua : Obj_Mono
{
    public Obj_YanHua()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_YANHUA;
    }

    private int m_nOwerobjID = -1;
    public int OwerobjID
    {
        get { return m_nOwerobjID; }
        set { m_nOwerobjID = value; }
    }
    private UInt64 m_OwnerGuid = GlobeVar.INVALID_GUID;
    public System.UInt64 OwnerGuid
    {
        get { return m_OwnerGuid; }
        set { m_OwnerGuid = value; }
    }

    private int m_nYanHuaId = -1;
    public int YanHuaId
    {
        get { return m_nYanHuaId; }
        set { m_nYanHuaId = value; }
    }
    public class ObjYanHua_Init_Data
    {

    }
    public bool Init(ObjYanHua_Init_Data initData)
    {
        // m_ObjTransform = transform;

        //服务器发过来的信息               
       
        //初始化特效
      
        //播放特效
        
        return true;
    }
}
