using UnityEngine;
using UnityEditor;
using Microsoft.Win32;
using jp.unisakistudio.coolposing;
using System.Collections.Generic;

namespace jp.unisakistudio.coolposingeditor
{

    [CustomEditor(typeof(CoolPosing))]
    public class CoolPosingEditor : posingsystemeditor.PosingSystemEditor
    {
        const string REGKEY = @"SOFTWARE\UnisakiStudio";
        const string APPKEY = "coolposing";
        private bool isCoolPosingLicensed = false;

        static CoolPosingEditor()
        {
            checkFunctions.Add(CheckExistFolderCoolPosing);
        }

        public override void OnInspectorGUI()
        {
            CoolPosing coolPosing = target as CoolPosing;

            /*
             * このコメント分を含むここから先の処理はカッコいいポーズツールをゆにさきスタジオから購入した場合に変更することを許可します。
             * つまり購入者はライセンスにまつわるこの先のソースコードを削除して再配布を行うことができます。
             * 逆に、購入をせずにGitHubなどからソースコードを取得しただけの場合、このライセンスに関するソースコードに手を加えることは許可しません。
             */
            if (!isCoolPosingLicensed)
            {
                var header1Label = new GUIStyle(EditorStyles.label) { fontStyle = FontStyle.Bold, fontSize = 20, };

                bool hasLicense = false;

                // Windows: レジストリをチェック
#if UNITY_EDITOR_WIN
                try
                {
                    var regKey = Registry.CurrentUser.CreateSubKey(REGKEY);
                    var regValue = (string)regKey.GetValue(APPKEY);
                    if (regValue == "licensed")
                    {
                        hasLicense = true;
                    }
                }
                catch (System.Exception)
                {
                    // レジストリアクセスに失敗した場合は次のチェックへ
                }
#endif

                // Mac/Linux: 設定ファイルをチェック
#if UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
                if (!hasLicense)
                {
                    try
                    {
                        string licenseFilePath = GetLicenseFilePath();
                        if (System.IO.File.Exists(licenseFilePath))
                        {
                            string fileContent = System.IO.File.ReadAllText(licenseFilePath);
                            if (fileContent == "licensed")
                            {
                                hasLicense = true;
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        // ファイルアクセスに失敗
                    }
                }
#endif

                if (hasLicense)
                {
                    isCoolPosingLicensed = true;
                }
                else
                {
                    EditorGUILayout.LabelField("カッコいいポーズツール", header1Label, GUILayout.Height(30));

                    EditorGUILayout.HelpBox("このコンピュータにはカッコいいポーズツールの使用が許諾されていません。Boothのショップからカッコいいポーズツールを購入して、コンピュータにライセンスをインストールしてください。カッコいいポーズツールを購入しているのにこのエラーが表示される場合は、Boothから最新版のZipファイルをダウンロードして、「CoolPosing.unitypackage」をインポートしてください。（この作業は１つのパソコンにつき一回行う必要があります）", MessageType.Error);
                    if (EditorGUILayout.LinkButton("カッコいいポーズツール（BOOTH）"))
                    {
                        Application.OpenURL("https://yunisaki.booth.pm/items/8797334");
                    }
                    return;
                }
            }
            /*
             * ライセンス処理ここまで
             */

            base.OnInspectorGUI();
        }

        private static string GetLicenseFilePath()
        {
#if UNITY_EDITOR_OSX
            string appSupport = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            return System.IO.Path.Combine(appSupport, "UnisakiStudio", $"{APPKEY}.lic");
#elif UNITY_EDITOR_LINUX
            string homeDir = System.Environment.GetEnvironmentVariable("HOME");
            return System.IO.Path.Combine(homeDir, ".local", "share", "UnisakiStudio", $"{APPKEY}.lic");
#else
            return null;
#endif
        }

        private static readonly List<string> folderDefines = new()
        {
            "Assets/UnisakiStudio/CoolPosing",
        };

        static public List<string> CheckExistFolderCoolPosing()
        {
            List<string> existFolders = new();
            foreach (var folderDefine in folderDefines)
            {
                if (AssetDatabase.IsValidFolder(folderDefine))
                {
                    existFolders.Add(folderDefine);
                }
            }
            return existFolders;
        }

    }
}
