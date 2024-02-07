using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXP_Range : MonoBehaviour
{
    [Range(0, 10)]  // 인스펙터에서 이 필드의 범위를 0에서 10으로 제한
    public int myRange;
}
