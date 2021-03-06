﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{

    public static EnemyManager instance { get; private set; }

    public int m_MaxEnemyNum = 5;
    public GameObject[] m_EnemyPrefabs;
    public Vector2 m_PosXBounds;
    public Vector2 m_PosYBounds;


    // int : ID of view
    [HideInInspector]
    public List<RoleBase> m_Enemies =
        new List<RoleBase>();
    private Vector3 tempTarget = Vector3.zero;

    private bool m_StartCreateEnemy = false;

    protected void OnEnable()
    {
        if (EnemyManager.instance == null)
        {
            EnemyManager.instance = this;
        }

        m_StartCreateEnemy = false;
    }

    void Awake()
    {
        // this.SetDataByCrossSceneDataMng();
    }

    void Start()
    {
        CreateEnemyWave();
        this.StartCreateEnemy();
    }

    void Update()
    {
        if (!m_StartCreateEnemy) return;

        if (!Global.instance.m_GameStart) return;

        // while (m_Enemies.Count < m_MaxEnemyNum)
        // {
        //     this.CreateOneEnemy();
        // }
        if (Input.GetKeyDown(KeyCode.M))
        {
            CreateEnemyWave();
        }
    }
    public void CreateEnemyWave()
    {
        CreateEnemyWave(8, 0, 0, 6, 8);
    }
    private void CreateEnemyWave(int num, float anchorX, float anchorY, float mixArea, float maxArea)
    {
        for (int i = 0; i < num; i++)
        {
            float temX = Random.Range(1, 100);

            if (temX > 50)
            {

                temX = Random.Range((anchorX + mixArea), (anchorX + maxArea));
            }
            else
            {
                temX = -Random.Range((anchorX + mixArea), (anchorX + maxArea));
            }
            float temY = Random.Range(1, 100);
            if (temY > 50)
            {

                temY = Random.Range((anchorY + mixArea), (anchorY + maxArea));
            }
            else
            {
                temY = -Random.Range((anchorY + mixArea), (anchorY + maxArea));
            }
            Vector3 testPos = new Vector3(temX, temY);
            GameObject oneE = m_EnemyPrefabs[Random.Range(0, m_EnemyPrefabs.Length)];
            GameObject eGO = Instantiate(
            Resources.Load("Enemy/" + oneE.name),
            testPos,
            Quaternion.identity) as GameObject;

        }

    }
    private void SetDataByCrossSceneDataMng()
    {
        CrossSceneDataManager crossMng = CrossSceneDataManager.instance;
        if (crossMng == null) return;

        switch (crossMng.m_NetworkMode)
        {
            case NetworkMode.PVP_Solo:
            case NetworkMode.PVP_Double:
                {
                    m_MaxEnemyNum = 0;
                }
                break;

            case NetworkMode.PVE_Solo:
            case NetworkMode.PVE_Double:
                {
                    m_MaxEnemyNum = 1;
                }
                break;
        }
    }

    public void StartCreateEnemy()
    {
        m_StartCreateEnemy = true;
    }

    public void CreateOneEnemy()
    {
        Vector3 testPos = new Vector3(
            Random.Range(m_PosXBounds.x, m_PosXBounds.y),
            Random.Range(m_PosYBounds.x, m_PosYBounds.y));
        GameObject oneE = m_EnemyPrefabs[Random.Range(0, m_EnemyPrefabs.Length)];
        GameObject eGO = Instantiate(
            Resources.Load("Enemy/" + oneE.name),
            testPos,
            Quaternion.identity) as GameObject;
        // Debug.Log("Create Enemy !!! " + "name : " + oneE.name);
    }

    public void RemoveEnemy(RoleBase enemy)
    {
        // Debug.Log(enemy.name + " is been destroyed");
        m_Enemies.Remove(enemy);
        GameObject.Destroy(enemy.gameObject, 2f);
    }

    public void InitEnemyStatus(RoleStatus status)
    {
        foreach (Enemy one in m_Enemies)
        {
            one.m_CurStatus = status;
        }
    }

}
