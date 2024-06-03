using kesera2.FBXOptionsManager;
using NUnit.Framework;
using UnityEditor;

public class FBXOptionsManagerViewTest
{
    private static FBXOptionsManager window;

    [SetUp]
    public void Setup()
    {
        window = EditorWindow.GetWindow<FBXOptionsManager>("Test Window");
    }
    [Test]
    public void TestShowWindow()
    {
        Assert.IsNotNull(window);
    }

    [Test]
    public void TestRelativePath()
    {
        Assert.That(window.relativePath.StartsWith("Assets"));
    }

    [Test]
    public void TestButtonClick()
    {
        // �E�B���h�E��\������
        FBXOptionsManager.ShowWindow();

        // �{�^�����N���b�N����
        //EditorWindow.GetWindow<FBXOptionsManager>().OnGUI();
        //Assert.AreEqual("Default Value", EditorWindow.GetWindow<FBXOptionsManager>()._myString);
    }
}
