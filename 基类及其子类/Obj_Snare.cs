using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;
using System;

public class Obj_Snare : Obj_Mono
{
    public Obj_Snare()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_SNARE;
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

    private int m_nSnareId = -1;
    public int SnareId
    {
        get { return m_nSnareId; }
        set { m_nSnareId = value; }
    }
    public class ObjSnare_Init_Data
    {

    }
    public bool Init(ObjSnare_Init_Data initData)
    {
        // m_ObjTransform = transform;

        //����������������Ϣ               

        //��������ĸ߶Ⱥ������ͷ���һ��

        //��ʼ����Ч

        //������������Ч

        //������������Ч

        return true;
    }
}