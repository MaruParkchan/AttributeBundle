using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXP_ContextMenu : MonoBehaviour
{
    [ContextMenu("My Function")]  // 인스펙터에서 컨텍스트 메뉴 추가, 선택 시 MyFunction() 실행
    void MyFunction()
    {
        Debug.Log("My Function was called!");
    }
}
