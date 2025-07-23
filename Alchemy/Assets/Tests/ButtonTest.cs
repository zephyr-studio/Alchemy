using Alchemy.Inspector;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    [Button]
    public void Foo() { }

    [Button]
    [LabelText("Bar!!!")]
    public void Bar() { }
}
