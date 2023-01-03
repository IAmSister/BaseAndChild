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
    /// ��Ч����
    /// </summary>
    public enum EffectType
    {
        TYPE_NORMAL = 0,
        TYPE_CHANGEMODEL = 1,
        TYPE_CHANGBLUE = 2,//���ʱ���
    }
    /// <summary>
    /// ������Ч������
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
    /// �����Ч������
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
    //��׿���������
    private Obj_OtherPlayer m_ObjOtherPlayer;
    private bool m_IsValue = false;
    private bool m_IsOk = false;//

    //  private Dictionary<int, List<FXController>> m_dicEffectCache = new Dictionary<int, List<FXController>>();
    private Dictionary<int, int> m_EffectCountCache = new Dictionary<int, int>();//����ͬһ����Ч������
    public Dictionary<int, int> EffectCountCache
    {
        get { return m_EffectCountCache; }
    }

    public delegate void PlayEffectDelegate(GameObject effectObj, object param);

    private List<int> m_NeedPlayEffectIdCache = new List<int>();

    GameObject m_EffectGameObj;
    Obj_Mono m_EffectObj = null;
    private Dictionary<string, GameObject> m_effectBindPointCache = new Dictionary<string, GameObject>(); // �󶨵㻺��

    public bool IsHaveBindPoint(string strPoint)
    {
        if (m_effectBindPointCache.ContainsKey(strPoint) && m_effectBindPointCache[strPoint] != null)
        {
            return true;
        }
        return false;
    }

    public const string m_NormalPonintName = "EffectPoint"; //ͨ�õ�
    public EffectLogic()
    {

    }
    //��Ӷ�NPC��Ч����������ָ���Ч��20s�ڻ�û�б�ʹ�ù���ɾ����
    private float m_Time = 20f;
    private float m_WhileTime = 10f;
    private float m_TagTime = 0f;

    /// <summary>
    /// ÿ��һ����ʱ��ɾ��һ�λ�����Ϣ
    /// </summary>
    private void FixedUpdate()
    {
        //��ʱ
        //DeleteNPCList ɾ��NPC����
    }
    /// <summary>
    /// ɾ��NPC����
    /// </summary>
    private void DeleteNPCList()
    {
        //����ǵͶ˻� ɾ���϶����ЧЧ��
        //ɾ��һЩ��Ч
        //���������С��0
    }
    /// <summary>
    /// ��ʼ����Ч
    /// </summary>
    /// <param name="effGameObj"></param>
    public void InitEffect(GameObject effGameObj)
    {
        //�����Ч�� �������
    }
    /// <summary>
    /// �����Ч�������ӹ�������isOnylDeactiveΪtrue����������÷��ص�ID���в�����ֹͣ����
    /// </summary>
    /// <param name="parentObj"></param>
    /// <param name="effectData"></param>
    /// <param name="delPlayEffect"></param>
    /// <param name="param"></param>
    public void AddEffect(GameObject parentObj, Tab_Effect effectData, PlayEffectDelegate delPlayEffect, object param)
    {
        //��Ч�����  �Ѿ����� ������һ
        //������ ���  ����Ϊ1

        //��׿
        //����ǰ�׿�Ͷ˻�  �߼����� 
        // �������߼�����

    }
    /// <summary>
    /// ͨ���������ݽ��м���
    /// </summary>
    /// <param name="name"></param>
    /// <param name="resObj"></param>
    /// <param name="param1"></param>
    /// <param name="param2"></param>
    /// <param name="param3"></param>
    private void OnAddEffectDataLoad(string name, GameObject resObj, object param1, object param2, object param3)
    {
        //�������ݲ�Ϊ��
        //ʵ������Դ����
        //�Ƕ�λ�ô�С
        //ͷ��� ��������ƫ������
        //�������ĵ��� ��������ƫ������
        //�ֵͶ˻�  �� ������
    }
    /// <summary>
    ///  ��ʼ����Ч�ҵĵ�λ����Ϣ
    /// </summary>
    public void InitEffectPointInfo()
    {
        //ͨ�ýڵ�
        //�������ĵ�
        //ͷ�ڵ�
        //���֣���ǰ�㣩�ڵ�
        //���֣���ǰ�㣩�ڵ�
        //��ţ�����㣩�ڵ�
        //�ҽţ��Һ��㣩�ڵ�

    }
    /// <summary>
    /// ������Ч,ֻ����type= 0����Ч
    /// </summary>
    /// <param name="effectID"></param>
    /// <param name="delPlayEffect"></param>
    /// <param name="param"></param>
    public void PlayEffect(int effectID, PlayEffectDelegate delPlayEffect = null, object param = null)
    { }
    /// <summary>
    /// �Ƿ��б�ɫ��Ч
    /// </summary>
    /// <returns></returns>
    public bool IsHaveChangeColorEffct() { return false; }
    /// <summary>
    /// ͨ��id��ȡ��Ч����
    /// </summary>
    /// <param name="effectID"></param>
    /// <returns></returns>
    public int GetEffectCountById(int effectID)
    { return 0; }
    /// <summary>
    /// ֹͣNPC������Ч
    /// </summary>
    public void NPCStopEffect() { }
    /// <summary>
    /// ֹͣ��Ч����
    /// </summary>
    /// <param name="effectID"></param>
    /// <param name="bStopAll"></param>
    public void StopEffect(int effectID, bool bStopAll = true) { }//���ŵ�ֹͣ ���صĲ���Ҫstop
    /// <summary>
    /// ������Ч
    /// </summary>
    public void ClearEffect() { }
    /// <summary>
    /// �Ƿ������Ч
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
        //����������Ч������Ļص�
    }
    /// <summary>
    /// ��Ч����
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
    { //��Чֹͣ ������1
      //����������Ч������Ļص�
    }
    /// <summary>
    /// ������Ч
    /// </summary>
    /// <param name="effectData"></param>
    /// <param name="delPlayEffect"></param>
    /// <param name="param"></param>
    void LoadEffect(Tab_Effect effectData, PlayEffectDelegate delPlayEffect, object param)
    {
    }
}

