using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("MyScript")]  // 컴포넌트 메뉴에 추가
[DisallowMultipleComponent]  // 중복 컴포넌트 추가 방지
[RequireComponent(typeof(Rigidbody))]  // Rigidbody 컴포넌트가 필요함
public class AttributeBundle : MonoBehaviour
{
    [SerializeField]  // private 필드가 인스펙터에서 보이게 함
    private int myInt;

    [HideInInspector]  // public 필드가 인스펙터에서 보이지 않게 함
    public string myString;

    [Range(0, 10)]  // 인스펙터에서 이 필드의 범위를 0에서 10으로 제한
    public int myRange;

    [Tooltip("This is a tooltip")]  // 이 필드 위에 마우스를 놓으면 툴팁이 표시됨
    public float myFloat;

    [Header("My Header")]  // 필드 그룹 위에 헤더를 추가
    public bool myBool;

    [Space]  // 필드 그룹 사이에 공간 추가
    public Vector3 myVector;

    [TextArea]  // 문자열 필드를 여러 줄 텍스트 입력 영역으로 만듦
    public string myText;

    [Multiline]  // 문자열 필드를 여러 줄 입력 가능하게 만듦
    public string myMultilineText;

    [ContextMenu("My Function")]  // 인스펙터에서 컨텍스트 메뉴 추가, 선택 시 MyFunction() 실행
    void MyFunction()
    {
        Debug.Log("My Function was called!");
    }

    [ContextMenuItem("Item Name", "MyFunction")]  // 인스펙터에서 컨텍스트 메뉴 항목 추가, 선택 시 MyFunction() 실행
    public string contextMenu;

    [ExecuteInEditMode]  // 에디터 모드에서도 스크립트 실행
    void Awake()
    {
        Debug.Log("Awake called!");
    }

    [ExecuteAlways]  // 항상 스크립트 실행
    void Update()
    {
        Debug.Log("Update called!");
    }
}
