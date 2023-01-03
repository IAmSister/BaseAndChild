using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Tab_Effect
{

}
public class FXController
{

}
public class EffectLogic : MonoBehaviour
{
    /// <summary>
    /// 特效类型
    /// </summary>
    public enum EffectType
    {
        TYPE_NORMAL = 0,
        TYPE_CHANGEMODEL = 1,
        TYPE_CHANGBLUE = 2,//材质变蓝
    }
    /// <summary>
    /// 播放特效的数据
    /// </summary>
    private class PlayEffectData
    {
        public PlayEffectData(string effectPath, GameObject parentObj, Vector3 effectPos, Vector3 effectRot, float duration, float delay = 0)
        {
            _effectPath = effectPath;
            _parentObj = parentObj;
            _effectPos = effectPos;
            _effectRot = effectRot;
            _duration = duration;
            _delay = delay;
        }

        public string _effectPath;
        public GameObject _parentObj;
        public Vector3 _effectPos;
        public Vector3 _effectRot;
        public float _duration;
        public float _delay;
    }
    /// <summary>
    /// 添加特效的数据
    /// </summary>
    private class AddEffectData
    {
        //public AddEffectData(GameObject parentObj, Tab_Effect effectData, PlayEffectDelegate delPlayEffect, object param)
        //{
        //    _parentObj = parentObj;
        //    _effectData = effectData;
        //    _delPlayEffect = delPlayEffect;
        //    _param = param;
        //}

        //public GameObject _parentObj;
        //public Tab_Effect _effectData;
        //public PlayEffectDelegate _delPlayEffect;
        //public object _param;

    }
    //安卓情况下适用
    private Obj_OtherPlayer m_ObjOtherPlayer;
    private bool m_IsValue = false;
    private bool m_IsOk = false;//

    //  private Dictionary<int, List<FXController>> m_dicEffectCache = new Dictionary<int, List<FXController>>();
    private Dictionary<int, int> m_EffectCountCache = new Dictionary<int, int>();//缓存同一个特效的数量
    public Dictionary<int, int> EffectCountCache
    {
        get { return m_EffectCountCache; }
    }

    public delegate void PlayEffectDelegate(GameObject effectObj, object param);

    private List<int> m_NeedPlayEffectIdCache = new List<int>();

    GameObject m_EffectGameObj;
    Obj_Mono m_EffectObj = null;
    private Dictionary<string, GameObject> m_effectBindPointCache = new Dictionary<string, GameObject>(); // 绑定点缓存

    public bool IsHaveBindPoint(string strPoint)
    {
        if (m_effectBindPointCache.ContainsKey(strPoint) && m_effectBindPointCache[strPoint] != null)
        {
            return true;
        }
        return false;
    }

    public const string m_NormalPonintName = "EffectPoint"; //通用点
    public EffectLogic()
    {

    }
    //添加对NPC特效管理。如果发现该特效在20s内还没有被使用过，删除掉
    private float m_Time = 20f;
    private float m_WhileTime = 10f;
    private float m_TagTime = 0f;

    /// <summary>
    /// 每隔一定的时间删除一次缓存信息
    /// </summary>
    private void FixedUpdate()
    {
        //计时
        //DeleteNPCList 删除NPC集合
    }
    /// <summary>
    /// 删除NPC集合
    /// </summary>
    private void DeleteNPCList()
    {
        //如果是低端机 删除较多的特效效果
        //删除一些特效
        //缓存池数量小于0
    }
    /// <summary>
    /// 初始化特效
    /// </summary>
    /// <param name="effGameObj"></param>
    public void InitEffect(GameObject effGameObj)
    {
        //清除特效点 缓存清空
    }
    /// <summary>
    /// 添加特效，如果添加过，并且isOnylDeactive为true，则可以利用返回的ID进行播放与停止操作
    /// </summary>
    /// <param name="parentObj"></param>
    /// <param name="effectData"></param>
    /// <param name="delPlayEffect"></param>
    /// <param name="param"></param>
    public void AddEffect(GameObject parentObj, Tab_Effect effectData, PlayEffectDelegate delPlayEffect, object param)
    {
        //特效对象池  已经存在 数量加一
        //不存在 添加  数量为1

        //安卓
        //如果是安卓低端机  逻辑处理 
        // 其他的逻辑处理

    }
    /// <summary>
    /// 通过技能数据进行加载
    /// </summary>
    /// <param name="name"></param>
    /// <param name="resObj"></param>
    /// <param name="param1"></param>
    /// <param name="param2"></param>
    /// <param name="param3"></param>
    private void OnAddEffectDataLoad(string name, GameObject resObj, object param1, object param2, object param3)
    {
        //所有数据不为空
        //实例化资源物体
        //角度位置大小
        //头结点 坐标特殊偏移修正
        //身体中心点结点 坐标特殊偏移修正
        //分低端机  和 其他的
    }
    /// <summary>
    ///  初始化特效挂的的位置信息
    /// </summary>
    public void InitEffectPointInfo()
    {
        //通用节点
        //身体中心点
        //头节点
        //左手（左前足）节点
        //右手（右前足）节点
        //左脚（左后足）节点
        //右脚（右后足）节点

    }
    /// <summary>
    /// 播放特效,只接受type= 0的特效
    /// </summary>
    /// <param name="effectID"></param>
    /// <param name="delPlayEffect"></param>
    /// <param name="param"></param>
    public void PlayEffect(int effectID, PlayEffectDelegate delPlayEffect = null, object param = null)
    { }
    /// <summary>
    /// 是否有变色特效
    /// </summary>
    /// <returns></returns>
    public bool IsHaveChangeColorEffct() { return false; }
    /// <summary>
    /// 通过id获取特效数量
    /// </summary>
    /// <param name="effectID"></param>
    /// <returns></returns>
    public int GetEffectCountById(int effectID)
    { return 0; }
    /// <summary>
    /// 停止NPC所有特效
    /// </summary>
    public void NPCStopEffect() { }
    /// <summary>
    /// 停止特效播放
    /// </summary>
    /// <param name="effectID"></param>
    /// <param name="bStopAll"></param>
    public void StopEffect(int effectID, bool bStopAll = true) { }//播放的停止 隐藏的不需要stop
    /// <summary>
    /// 清理特效
    /// </summary>
    public void ClearEffect() { }
    /// <summary>
    /// 是否包含特效
    /// </summary>
    /// <param name="effectID"></param>
    /// <returns></returns>
    public bool ContainsEffect(int effectID)
    {
        return false;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="curController"></param>
    public void EffectDeactive(FXController curController)
    {
        //技能升级特效播放完的回调
    }
    /// <summary>
    /// 特效销毁
    /// </summary>
    /// <param name="effectID"></param>
    public void EffectDestroyed(int effectID)
    {
        OnEffectOver(effectID);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="effectID"></param>
    void OnEffectOver(int effectID)
    { //特效停止 数量减1
      //技能升级特效播放完的回调
    }
    /// <summary>
    /// 加载特效
    /// </summary>
    /// <param name="effectData"></param>
    /// <param name="delPlayEffect"></param>
    /// <param name="param"></param>
    void LoadEffect(Tab_Effect effectData, PlayEffectDelegate delPlayEffect, object param)
    {
    }
}

