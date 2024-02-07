using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXP_HideInInspector : MonoBehaviour
{
    [HideInInspector]  // public 필드가 인스펙터에서 보이지 않게 함
    public string myString;
}
