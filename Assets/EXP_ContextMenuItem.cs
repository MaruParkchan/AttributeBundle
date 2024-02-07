using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXP_ContextMenuItem : MonoBehaviour
{
    [ContextMenuItem("Item Name", "MyFunction")]  // 인스펙터에서 컨텍스트 메뉴 항목 추가, 선택 시 MyFunction() 실행
    public string contextMenu;
}
