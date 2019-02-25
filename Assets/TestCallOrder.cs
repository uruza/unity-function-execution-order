﻿
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class TestCallOrder : MonoBehaviour
{
    bool firstCalledUpdate;

    private void Awake()
    {
        Debug.LogFormat( "{0}.{1}.{2}", name, GetType().Name, MethodBase.GetCurrentMethod().Name );
    }

    void Start()
    {
        Debug.LogFormat( "{0}.{1}.{2}", name, GetType().Name, MethodBase.GetCurrentMethod().Name );
    }

    void Update()
    {
        if ( firstCalledUpdate ) {
            return;
        }

        Debug.LogFormat( "{0}.{1}.{2}", name, GetType().Name, MethodBase.GetCurrentMethod().Name );

        firstCalledUpdate = true;
    }
}






//using System.Collections;
//using System.Collections.Generic;
//using System.Reflection;
//using UnityEngine;

//public class MonoExeOrder : MonoBehaviour
//{
//    public bool showFrameLog = true;
//    public bool showFuncLog = true;
//    public int currFrameNum;
//    int prevFrameNum;
//    bool firstFixedUpdate = true;

//    void LogFrameStart()
//    {
//        if ( showFrameLog ) {
//            Debug.LogFormat( "<color=lightblue>[Frame {0}] ----- Start -----</color>", currFrameNum );
//        }
//    }

//    void LogFrameEnd()
//    {
//        if ( showFrameLog ) {
//            Debug.LogFormat( "[Frame {0}] ----- End -----", currFrameNum );
//        }
//    }

//    void LogFuncFlow( string flowName )
//    {
//        if ( showFuncLog ) {
//            Debug.LogFormat( "[Frame {0}] Flow : {1}", currFrameNum, flowName );
//        }
//    }

//    private void Awake()
//    {

//        LogFuncFlow( MethodBase.GetCurrentMethod().Name );
//        StartCoroutine( CoWaitForFixedUpdate() );
//    }

//    private void OnEnable()
//    {
//        LogFuncFlow( MethodBase.GetCurrentMethod().Name );
//    }

//    private void Reset()
//    {
//        LogFuncFlow( MethodBase.GetCurrentMethod().Name );
//    }

//    void Start()
//    {
//        LogFuncFlow( MethodBase.GetCurrentMethod().Name );
//        StartCoroutine( CoNull() );
//    }

//    IEnumerator CoNull()
//    {

//        LogFuncFlow( "Start Coroutine" );

//        while ( true ) {
//            LogFuncFlow( "yield return null" );
//            yield return null;
//        }
//    }

//    IEnumerator CoWaitForFixedUpdate()
//    {
//        yield return new WaitForFixedUpdate();
//    }

//    private void FixedUpdate()
//    {
//        if ( firstFixedUpdate ) {
//            firstFixedUpdate = false;
//            prevFrameNum = currFrameNum;
//            currFrameNum++;
//            if ( currFrameNum < 0 ) {
//                currFrameNum = 0;
//            }
//            LogFrameStart();
//        }

//        LogFuncFlow( MethodBase.GetCurrentMethod().Name );
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        firstFixedUpdate = true;
//        LogFuncFlow( MethodBase.GetCurrentMethod().Name );
//    }

//    private void LateUpdate()
//    {
//        LogFuncFlow( MethodBase.GetCurrentMethod().Name );
//    }

//    private void OnRenderImage( RenderTexture source, RenderTexture destination )
//    {
//        LogFuncFlow( MethodBase.GetCurrentMethod().Name );
//        LogFrameEnd();
//    }

//}