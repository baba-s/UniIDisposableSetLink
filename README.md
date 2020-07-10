# UniIDisposableSetLink

ゲームオブジェクトの OnDestroy 時に IDisposable.Dispose を自動で呼び出す機能

## 使用例

```cs
using Kogane;
using System;
using UnityEngine;

public class Hoge : IDisposable
{
    public void Dispose()
    {
        Debug.Log( "ピカチュウ" );
    }
}

public class Example : MonoBehaviour
{
    private void Awake()
    {
        // Example コンポーネントがアタッチされているゲームオブジェクトの
        // OnDestroy が呼び出された時に Hoge.Dispose が自動で呼び出される
        new Hoge().SetLink( gameObject );
    }
}
```
