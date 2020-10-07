using UnityEngine;
using System.Collections;

public class ObjectFall : Objectbase
{
    private Rigidbody rig;

    protected override void Awake()
    {
        base.Awake();                          // 保留 父類別 內的程式內容

        rig = GetComponent<Rigidbody>();
    }

    protected override IEnumerator Action()
    {
        enabled = false;                                   // 此腳本 啟動 = 否

        yield return new WaitForSeconds(delay);            // 延遲

        aud.PlayOneShot(sound, volume);

        rig.useGravity = true;
    }
}
