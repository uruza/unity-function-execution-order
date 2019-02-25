
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




