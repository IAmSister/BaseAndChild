using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;

public class Obj_Fellow : Obj_Character
{
    public Obj_Fellow()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_FELLOW;
        m_OwnerObjId = -1;
    }

    public  bool Init(Obj_Init_Data initData)//override
    {
        
        //暂时 写死了 后面再用服务器
        m_ObjTransform.Rotate(Vector3.up * 135);

        //服务器发过来的信息               

        //防止伙伴追上人物导致动作不流畅 把客户端主角伙伴速度修改为和人物一样
        //初始化CharModelID，并读取部分客户端信息
        //设置动作路径
        //设置名字版高度
        //初始化寻路代理

        //初始化AutoMove功能模块

        //初始化动画，需要在AnimationFilePath被赋值后进行

        //AnimLogic = gameObject.GetComponent<AnimationLogic>();
        //初始化特效
        //召出播放特效

        //播放音效 改为UI召唤按钮播

        return false;
    }

    /// <summary>
    /// 进入可视区域
    /// </summary>
    void OnBecameVisible()
    {
        //设置是否在视口内标记位，为其他系统优化判断标识
        //显示名字版
        //显示模型 
    }

    /// <summary>
    /// 离开可视区域
    /// </summary>
    void OnBecameInvisible()
    {
        //设置是否在视口内标记位，为其他系统优化判断标识
        //隐藏名字版
        //隐藏模型
    }

    /// <summary>
    /// 更新Obj_Fellow逻辑数据
    /// </summary>
    void FixedUpdate()
    {
        //主角伙伴移动
        //技能结束检测  
    }

    void InitNameBoard()
    {
       // ResourceManager.LoadHeadInfoPrefab(UIInfo.FellowHeadInfo, gameObject, "FellowHeadInfo", OnLoadNameBoard);
    }

    void OnLoadNameBoard(GameObject objNameBoard)
    {
      
    }

    public  Color GetNameBoardColor()//override
    {
        //伙伴名字根据品质决定
        return new Color();
    }

    /// <summary>
    /// 伙伴品质
    /// </summary>
    private int m_Quality;
    public int Quality
    {
        get { return m_Quality; }
        set { m_Quality = value; }
    }

    private int m_OwnerObjId;
    public int OwnerObjId
    {
        get { return m_OwnerObjId; }
        set { m_OwnerObjId = value; }
    }

    /// <summary>
    /// 是否主角的伙伴
    /// </summary>
    public bool IsOwnedByMainPlayer()
    {
       
        return false;
    }

    /// <summary>
    /// 把主角伙伴客户端速度设置为与主角一致
    /// </summary>
    public void SetMoveSpeedAsMainPlayer()
    {
       
    }

    private void UpdateFellowMove()
    {
        //判读是否在战斗
        //距离太远 直接拉过去
    }

    private Vector3 GetFellowPos(Obj_MainPlayer mainPlayer)
    {
        //主角位置

        //主角朝向

        //旋转

        //平移

        return Vector3.back ;
    }

}
