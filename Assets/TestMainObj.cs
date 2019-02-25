
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class TestMainObj : MonoBehaviour
{
    private void Awake()
    {
        CreateTestObj( "AAA" );
        CreateTestObj( "BBB" );
        CreateTestObj( "CCC" );
    }

    void CreateTestObj ( string objName )
    {
        GameObject go = new GameObject( objName );
        go.AddComponent<TestCallOrder>();
        go.transform.SetParent( transform, false );
    }

    void Start()
    {

    }

    void Update()
    {

    }


}
